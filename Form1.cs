using System.Globalization;

namespace Examen_cafeteria_KendyBonilla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            
            private const decimal RECARGO_GRANDE = 25m;
            private const decimal RECARGO_EXTRA = 30m;
            private const decimal PORCENTAJE_DESCUENTO = 0.10m;
            private const decimal COSTO_EMPAQUE = 20m;
            private const decimal TASA_ITBIS = 0.18m;

            
            private const int ANCHO_CANTIDAD = 6;
            private const int ANCHO_PRODUCTO = 24;
            private const int ANCHO_PRECIO = 10;
            private const int ANCHO_TOTAL = 12;

            private decimal subtotalAcumulado = 0m;

           

            
            private void frmPedidos_Load(object sender, EventArgs e)
            {
                lblEncabezado.Text = FormatearLinea("Cant", "Producto", "Precio", "Total");
                ReiniciarTodo();
            }

            
            private void btnAgregar_Click(object sender, EventArgs e)
            {
                string nombreProducto = txtProducto.Text.Trim();
                if (string.IsNullOrWhiteSpace(nombreProducto))
                {
                    MessageBox.Show("Debe ingresar el nombre del producto.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProducto.Focus();
                    return;
                }

                if (!decimal.TryParse(txtPrecio.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out decimal precioDigitado) &&
                    !decimal.TryParse(txtPrecio.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out precioDigitado))
                {
                    MessageBox.Show("Ingrese un precio válido.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrecio.Focus();
                    txtPrecio.SelectAll();
                    return;
                }

                if (precioDigitado <= 0m)
                {
                    MessageBox.Show("El precio debe ser mayor que cero.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrecio.Focus();
                    txtPrecio.SelectAll();
                    return;
                }

                decimal precioUnitario = precioDigitado;
                string etiquetaDetalle = "Normal";

                if (rbtGrande.Checked && chkPorcionExtra.Checked)
                {
                    precioUnitario += RECARGO_GRANDE + RECARGO_EXTRA;
                    etiquetaDetalle = "Grande, Extra";
                }
                else if (rbtGrande.Checked)
                {
                    precioUnitario += RECARGO_GRANDE;
                    etiquetaDetalle = "Grande";
                }
                else if (chkPorcionExtra.Checked)
                {
                    precioUnitario += RECARGO_EXTRA;
                    etiquetaDetalle = "Extra";
                }

                int cantidad = (int)nudCantidad.Value;
                decimal totalLinea = precioUnitario * cantidad;
                subtotalAcumulado += totalLinea;

                string productoConDetalle = $"{nombreProducto} ({etiquetaDetalle})";
                string linea = FormatearLinea(
                    cantidad.ToString(),
                    productoConDetalle,
                    precioUnitario.ToString("0.00", CultureInfo.InvariantCulture),
                    totalLinea.ToString("0.00", CultureInfo.InvariantCulture)
                );

                lstPedido.Items.Add(linea);
                lblSubtotal.Text = FormatearMoneda(subtotalAcumulado);

                ReiniciarControlesProducto();
            }

            
            private void btnCalcular_Click(object sender, EventArgs e)
            {
                if (lstPedido.Items.Count == 0 || subtotalAcumulado <= 0m)
                {
                    MessageBox.Show("No hay productos en el pedido para calcular el total.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                decimal descuento = chkFrecuente.Checked ? subtotalAcumulado * PORCENTAJE_DESCUENTO : 0m;
                decimal empaque = rbtLlevar.Checked ? COSTO_EMPAQUE : 0m;
                decimal baseImponible = subtotalAcumulado - descuento + empaque;
                decimal itbis = baseImponible * TASA_ITBIS;
                decimal total = baseImponible + itbis;

                lblSubtotal.Text = FormatearMoneda(subtotalAcumulado);
                lblDescuento.Text = FormatearMoneda(descuento);
                lblEmpaque.Text = FormatearMoneda(empaque);
                lblItbis.Text = FormatearMoneda(itbis);
                lblTotal.Text = FormatearMoneda(total);
            }

            // Reinicia el formulario para un nuevo pedido y enfoca txtCliente
            private void btnLimpiar_Click(object sender, EventArgs e)
            {
                ReiniciarTodo();
                txtCliente.Focus();
            }

            // Solicita confirmación Sí/No antes de cerrar la aplicación
            private void btnSalir_Click(object sender, EventArgs e)
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Desea salir de la aplicación?",
                    "Confirmar salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    Close();
                }
            }

            // Alinea columnas usando PadRight y PadLeft
            private string FormatearLinea(string cant, string producto, string precio, string total)
            {
                if (producto.Length > ANCHO_PRODUCTO)
                {
                    producto = producto.Substring(0, ANCHO_PRODUCTO);
                }

                return cant.PadRight(ANCHO_CANTIDAD) +
                       producto.PadRight(ANCHO_PRODUCTO) +
                       precio.PadLeft(ANCHO_PRECIO) +
                       total.PadLeft(ANCHO_TOTAL);
            }

            // Formatea montos en pesos dominicanos (RD$ 0.00)
            private string FormatearMoneda(decimal monto)
            {
                return "RD$ " + monto.ToString("0.00", CultureInfo.InvariantCulture);
            }

            // Restablece los controles de captura de producto
            private void ReiniciarControlesProducto()
            {
                txtProducto.Clear();
                txtPrecio.Clear();
                nudCantidad.Value = 1;
                rbtNormal.Checked = true;
                chkPorcionExtra.Checked = false;
                txtProducto.Focus();
            }

            
            private void ReiniciarTodo()
            {
                subtotalAcumulado = 0m;
                txtCliente.Clear();
                dtpFecha.Value = DateTime.Today;
                chkFrecuente.Checked = false;
                rbtLocal.Checked = true;

                ReiniciarControlesProducto();
                lstPedido.Items.Clear();

                lblSubtotal.Text = FormatearMoneda(0m);
                lblDescuento.Text = FormatearMoneda(0m);
                lblEmpaque.Text = FormatearMoneda(0m);
                lblItbis.Text = FormatearMoneda(0m);
                lblTotal.Text = FormatearMoneda(0m);
            }
        }
    }

   