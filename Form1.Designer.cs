namespace Examen_cafeteria_KendyBonilla
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCliente = new TextBox();
            txtProducto = new TextBox();
            groupBox1 = new GroupBox();
            rbtGrande = new RadioButton();
            rbtNormal = new RadioButton();
            lblEmpaque = new Label();
            lblEncabezado = new Label();
            btnLimpiar = new Button();
            groupBox2 = new GroupBox();
            rbtLlevar = new RadioButton();
            rbtLocal = new RadioButton();
            lblSubtotal = new Label();
            lblItbis = new Label();
            lstPedido = new ListBox();
            lblDescuento = new Label();
            lblTotal = new Label();
            btnAgregar = new Button();
            btnCalcular = new Button();
            btnSalir = new Button();
            txtPrecio = new TextBox();
            chkFrecuente = new CheckBox();
            chkPorcionExtra = new CheckBox();
            dtpFecha = new DateTimePicker();
            nudCantidad = new NumericUpDown();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(96, 23);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(125, 27);
            txtCliente.TabIndex = 0;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(96, 100);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(125, 27);
            txtProducto.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtGrande);
            groupBox1.Controls.Add(rbtNormal);
            groupBox1.Location = new Point(538, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // rbtGrande
            // 
            rbtGrande.AutoSize = true;
            rbtGrande.Location = new Point(13, 88);
            rbtGrande.Name = "rbtGrande";
            rbtGrande.Size = new Size(78, 24);
            rbtGrande.TabIndex = 8;
            rbtGrande.TabStop = true;
            rbtGrande.Text = "Grande";
            rbtGrande.UseVisualStyleBackColor = true;
            // 
            // rbtNormal
            // 
            rbtNormal.AutoSize = true;
            rbtNormal.Location = new Point(13, 36);
            rbtNormal.Name = "rbtNormal";
            rbtNormal.Size = new Size(80, 24);
            rbtNormal.TabIndex = 7;
            rbtNormal.TabStop = true;
            rbtNormal.Text = "Normal";
            rbtNormal.UseVisualStyleBackColor = true;
            // 
            // lblEmpaque
            // 
            lblEmpaque.AutoSize = true;
            lblEmpaque.Location = new Point(382, 30);
            lblEmpaque.Name = "lblEmpaque";
            lblEmpaque.Size = new Size(72, 20);
            lblEmpaque.TabIndex = 4;
            lblEmpaque.Text = "Empaque";
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.Location = new Point(260, 30);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(90, 20);
            lblEncabezado.TabIndex = 5;
            lblEncabezado.Text = "Encabezado";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(322, 338);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtLlevar);
            groupBox2.Controls.Add(rbtLocal);
            groupBox2.Location = new Point(538, 196);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // rbtLlevar
            // 
            rbtLlevar.AutoSize = true;
            rbtLlevar.Location = new Point(22, 82);
            rbtLlevar.Name = "rbtLlevar";
            rbtLlevar.Size = new Size(117, 24);
            rbtLlevar.TabIndex = 1;
            rbtLlevar.TabStop = true;
            rbtLlevar.Text = "radioButton1";
            rbtLlevar.UseVisualStyleBackColor = true;
            // 
            // rbtLocal
            // 
            rbtLocal.AutoSize = true;
            rbtLocal.Location = new Point(22, 30);
            rbtLocal.Name = "rbtLocal";
            rbtLocal.Size = new Size(117, 24);
            rbtLocal.TabIndex = 0;
            rbtLocal.TabStop = true;
            rbtLocal.Text = "radioButton1";
            rbtLocal.UseVisualStyleBackColor = true;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(538, 393);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(65, 20);
            lblSubtotal.TabIndex = 8;
            lblSubtotal.Text = "Subtotal";
            // 
            // lblItbis
            // 
            lblItbis.AutoSize = true;
            lblItbis.Location = new Point(560, 338);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(37, 20);
            lblItbis.TabIndex = 9;
            lblItbis.Text = "Itbis";
            // 
            // lstPedido
            // 
            lstPedido.FormattingEnabled = true;
            lstPedido.Location = new Point(287, 185);
            lstPedido.Name = "lstPedido";
            lstPedido.Size = new Size(150, 104);
            lstPedido.TabIndex = 10;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(538, 360);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(79, 20);
            lblDescuento.TabIndex = 11;
            lblDescuento.Text = "Descuento";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(555, 422);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "Total";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(60, 334);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(186, 338);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 14;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(60, 393);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(291, 99);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 16;
            // 
            // chkFrecuente
            // 
            chkFrecuente.AutoSize = true;
            chkFrecuente.Location = new Point(96, 56);
            chkFrecuente.Name = "chkFrecuente";
            chkFrecuente.Size = new Size(95, 24);
            chkFrecuente.TabIndex = 17;
            chkFrecuente.Text = "Frecuente";
            chkFrecuente.UseVisualStyleBackColor = true;
            // 
            // chkPorcionExtra
            // 
            chkPorcionExtra.AutoSize = true;
            chkPorcionExtra.Location = new Point(120, 166);
            chkPorcionExtra.Name = "chkPorcionExtra";
            chkPorcionExtra.Size = new Size(113, 24);
            chkPorcionExtra.TabIndex = 18;
            chkPorcionExtra.Text = "PorcionExtra";
            chkPorcionExtra.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(30, 278);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 19;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(287, 393);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(150, 27);
            nudCantidad.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nudCantidad);
            Controls.Add(dtpFecha);
            Controls.Add(chkPorcionExtra);
            Controls.Add(chkFrecuente);
            Controls.Add(txtPrecio);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Controls.Add(btnAgregar);
            Controls.Add(lblTotal);
            Controls.Add(lblDescuento);
            Controls.Add(lstPedido);
            Controls.Add(lblItbis);
            Controls.Add(lblSubtotal);
            Controls.Add(groupBox2);
            Controls.Add(btnLimpiar);
            Controls.Add(lblEncabezado);
            Controls.Add(lblEmpaque);
            Controls.Add(groupBox1);
            Controls.Add(txtProducto);
            Controls.Add(txtCliente);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCliente;
        private TextBox txtProducto;
        private GroupBox groupBox1;
        private Label lblEmpaque;
        private Label lblEncabezado;
        private Button btnLimpiar;
        private RadioButton rbtGrande;
        private RadioButton rbtNormal;
        private GroupBox groupBox2;
        private RadioButton rbtLlevar;
        private RadioButton rbtLocal;
        private Label lblSubtotal;
        private Label lblItbis;
        private ListBox lstPedido;
        private Label lblDescuento;
        private Label lblTotal;
        private Button btnAgregar;
        private Button btnCalcular;
        private Button btnSalir;
        private TextBox txtPrecio;
        private CheckBox chkFrecuente;
        private CheckBox chkPorcionExtra;
        private DateTimePicker dtpFecha;
        private NumericUpDown nudCantidad;
    }
}
