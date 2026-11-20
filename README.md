# Examen_cafeteria_KendyBonilla
Kendy Manuel Bonilla Castillo (2026-0068)

## 2. Descripción del programa
Aplicación de escritorio en C# (Windows Forms) con el formulario `frmPedidos` para registrar productos de un pedido, aplicar recargos por tamaño y porción extra, y calcular subtotal, descuento por cliente frecuente, empaque para llevar, ITBIS y total a pagar.

## 3. Datos de entrada
- Nombre del cliente (`txtCliente`), fecha (`dtpFecha`) y condición de cliente frecuente (`chkFrecuente`).
- Producto (`txtProducto`), precio base (`txtPrecio`), cantidad (`nudCantidad` de 1 a 20).
- Tamaño (`rbtNormal` / `rbtGrande`), porción extra (`chkPorcionExtra`) y servicio (`rbtLocal` / `rbtLlevar`).

## 4. Proceso
- Cálculo de precio unitario (`+RD$25` si es grande, `+RD$30` si lleva porción extra) y total por línea (`precio unitario * cantidad`).
- Acumulación del subtotal y formato de columnas con `PadRight` y `PadLeft`.
- Cálculo de descuento (`10%` del subtotal si es frecuente), empaque (`RD$20` si es para llevar), base imponible (`subtotal - descuento + empaque`), ITBIS (`18%` de la base imponible) y total final.
- Confirmación con `MessageBox` (`Sí/No`) al salir y limpieza total en "Nuevo pedido".

## 5. Salida
- Detalle de líneas en `lstPedido` con encabezado en `lblEncabezado`.
- Montos formateados en `RD$ 0.00` en `lblSubtotal`, `lblDescuento`, `lblEmpaque`, `lblItbis` y `lblTotal`.

## 6. Capturas de pantalla
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/ff3264d8-93f0-4348-a7fe-5370e3e255ee" />

