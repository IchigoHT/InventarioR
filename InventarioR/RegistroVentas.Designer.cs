namespace ComplementodeVentas
{
    partial class RegistroVentas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblPrecio = new Label();
            label8 = new Label();
            cboPago = new ComboBox();
            cboProductos = new ComboBox();
            txtCantidad = new TextBox();
            groupBox1 = new GroupBox();
            txtNombre = new TextBox();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            lvVenta = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            btnSalir = new Button();
            lblFecha = new Label();
            btnBorrar = new Button();
            btnLimpiar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(273, 25);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(208, 18);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE VENTAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 36);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(217, 13);
            label2.TabIndex = 1;
            label2.Text = "Nombres y Apellidos del cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 76);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 13);
            label3.TabIndex = 2;
            label3.Text = "Seleccione productos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 116);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 13);
            label4.TabIndex = 3;
            label4.Text = "Tipo de pago:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(540, 49);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 13);
            label5.TabIndex = 4;
            label5.Text = "Fecha actual:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(454, 36);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(138, 13);
            label6.TabIndex = 5;
            label6.Text = "Precio del producto:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(463, 60);
            lblPrecio.Margin = new Padding(5, 0, 5, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(64, 13);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "lblPrecio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(338, 36);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(68, 13);
            label8.TabIndex = 7;
            label8.Text = "Cantidad:";
            // 
            // cboPago
            // 
            cboPago.FormattingEnabled = true;
            cboPago.Items.AddRange(new object[] { "Contado", "Tarjeta", "Yape", "Otros" });
            cboPago.Location = new Point(30, 132);
            cboPago.Margin = new Padding(5, 3, 5, 3);
            cboPago.Name = "cboPago";
            cboPago.Size = new Size(256, 21);
            cboPago.TabIndex = 9;
            // 
            // cboProductos
            // 
            cboProductos.FormattingEnabled = true;
            cboProductos.Items.AddRange(new object[] { "Coleccion de Pantalones", "Coleccion de Polos", "Coleccion de Blusas", "Coleccion de Casacas" });
            cboProductos.Location = new Point(30, 92);
            cboProductos.Margin = new Padding(5, 3, 5, 3);
            cboProductos.Name = "cboProductos";
            cboProductos.Size = new Size(256, 21);
            cboProductos.TabIndex = 10;
            cboProductos.SelectedIndexChanged += cboProductos_SelectedIndexChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(341, 52);
            txtCantidad.Margin = new Padding(5, 3, 5, 3);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(87, 21);
            txtCantidad.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MediumSeaGreen;
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(cboProductos);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblPrecio);
            groupBox1.Controls.Add(cboPago);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(14, 79);
            groupBox1.Margin = new Padding(5, 3, 5, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 3, 5, 3);
            groupBox1.Size = new Size(602, 171);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Area de ventas";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(30, 52);
            txtNombre.Margin = new Padding(5, 3, 5, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(256, 21);
            txtNombre.TabIndex = 12;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Navy;
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(157, 266);
            btnCancelar.Margin = new Padding(5, 3, 5, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 38);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Navy;
            btnRegistrar.ForeColor = SystemColors.ControlLightLight;
            btnRegistrar.Location = new Point(273, 266);
            btnRegistrar.Margin = new Padding(5, 3, 5, 3);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(96, 38);
            btnRegistrar.TabIndex = 15;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lvVenta
            // 
            lvVenta.BackColor = Color.Teal;
            lvVenta.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            lvVenta.Font = new Font("Verdana", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lvVenta.GridLines = true;
            lvVenta.Location = new Point(14, 321);
            lvVenta.Margin = new Padding(5, 3, 5, 3);
            lvVenta.Name = "lvVenta";
            lvVenta.Size = new Size(746, 132);
            lvVenta.TabIndex = 16;
            lvVenta.UseCompatibleStateImageBehavior = false;
            lvVenta.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "NOMBRES Y APELLIDOS";
            columnHeader1.Width = 163;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "PRODUCTOS";
            columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "CANTIDAD";
            columnHeader3.Width = 74;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "PRECIO";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "TIPO DE PAGO";
            columnHeader5.Width = 92;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "DESCUENTO";
            columnHeader6.Width = 74;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "RECARGO";
            columnHeader7.Width = 81;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "PRECIO TOTAL";
            columnHeader8.Width = 109;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Navy;
            btnSalir.ForeColor = SystemColors.ControlLightLight;
            btnSalir.Location = new Point(599, 468);
            btnSalir.Margin = new Padding(5, 3, 5, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(124, 36);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Location = new Point(661, 49);
            lblFecha.Margin = new Padding(5, 0, 5, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(62, 13);
            lblFecha.TabIndex = 18;
            lblFecha.Text = "lblFecha";
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Navy;
            btnBorrar.ForeColor = SystemColors.ControlLightLight;
            btnBorrar.Location = new Point(497, 266);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(109, 37);
            btnBorrar.TabIndex = 19;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Navy;
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(612, 268);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(95, 35);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // RegistroVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            BackgroundImage = InventarioR.Properties.Resources.bground;
            ClientSize = new Size(848, 507);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBorrar);
            Controls.Add(lblFecha);
            Controls.Add(btnSalir);
            Controls.Add(lvVenta);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(label5);
            Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 3, 5, 3);
            Name = "RegistroVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registo de Ventas";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboPago;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ListView lvVenta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private Button btnBorrar;
        private Button btnLimpiar;
    }
}

