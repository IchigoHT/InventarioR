namespace Inventario
{
    partial class ViewProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProductos = new DataGridView();
            ColumnProducto = new DataGridViewTextBoxColumn();
            ColumnProveedor = new DataGridViewTextBoxColumn();
            ColumnMarca = new DataGridViewTextBoxColumn();
            ColumnStock = new DataGridViewTextBoxColumn();
            ColumnCosto = new DataGridViewTextBoxColumn();
            ColumnDescripcion = new DataGridViewTextBoxColumn();
            Eliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label2 = new Label();
            txtmarca = new TextBox();
            txtproveedor = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtstock = new TextBox();
            label7 = new Label();
            txtcostoU = new TextBox();
            label8 = new Label();
            txtproducto = new TextBox();
            label9 = new Label();
            groupBox1 = new GroupBox();
            dateTimeFecha = new DateTimePicker();
            txtdescripcion = new TextBox();
            lblFecha = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.BackgroundColor = Color.Silver;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { ColumnProducto, ColumnProveedor, ColumnMarca, ColumnStock, ColumnCosto, ColumnDescripcion });
            dgvProductos.Location = new Point(22, 266);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(645, 254);
            dgvProductos.TabIndex = 20;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // ColumnProducto
            // 
            ColumnProducto.HeaderText = "Producto";
            ColumnProducto.Name = "ColumnProducto";
            // 
            // ColumnProveedor
            // 
            ColumnProveedor.HeaderText = "Proveedor";
            ColumnProveedor.Name = "ColumnProveedor";
            // 
            // ColumnMarca
            // 
            ColumnMarca.HeaderText = "Marca";
            ColumnMarca.Name = "ColumnMarca";
            // 
            // ColumnStock
            // 
            ColumnStock.HeaderText = "Stock";
            ColumnStock.Name = "ColumnStock";
            // 
            // ColumnCosto
            // 
            ColumnCosto.HeaderText = "Costo";
            ColumnCosto.Name = "ColumnCosto";
            // 
            // ColumnDescripcion
            // 
            ColumnDescripcion.HeaderText = "Descripcion";
            ColumnDescripcion.Name = "ColumnDescripcion";
            // 
            // Eliminar
            // 
            Eliminar.BackColor = Color.FromArgb(167, 255, 132);
            Eliminar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Eliminar.ForeColor = Color.Black;
            Eliminar.Location = new Point(642, 133);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(85, 33);
            Eliminar.TabIndex = 20;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = false;
            Eliminar.Click += Eliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(167, 255, 132);
            btnModificar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(642, 86);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(85, 33);
            btnModificar.TabIndex = 19;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(167, 255, 132);
            btnAgregar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(642, 37);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(85, 33);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Schoolbook", 12F);
            label2.Location = new Point(17, 151);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 17;
            label2.Text = "Marca:";
            // 
            // txtmarca
            // 
            txtmarca.BackColor = Color.Ivory;
            txtmarca.BorderStyle = BorderStyle.FixedSingle;
            txtmarca.Font = new Font("Calibri", 9.75F);
            txtmarca.Location = new Point(83, 151);
            txtmarca.Name = "txtmarca";
            txtmarca.Size = new Size(109, 23);
            txtmarca.TabIndex = 14;
            // 
            // txtproveedor
            // 
            txtproveedor.BackColor = Color.Ivory;
            txtproveedor.BorderStyle = BorderStyle.FixedSingle;
            txtproveedor.Font = new Font("Calibri", 9.75F);
            txtproveedor.Location = new Point(101, 83);
            txtproveedor.Name = "txtproveedor";
            txtproveedor.Size = new Size(144, 23);
            txtproveedor.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Schoolbook", 12F);
            label4.Location = new Point(16, 83);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 12;
            label4.Text = "Proveedor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Schoolbook", 12F);
            label5.Location = new Point(293, 47);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 9;
            label5.Text = "Fecha:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Schoolbook", 12F);
            label6.Location = new Point(293, 117);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 7;
            label6.Text = "Descripcion:";
            // 
            // txtstock
            // 
            txtstock.BackColor = Color.Ivory;
            txtstock.BorderStyle = BorderStyle.FixedSingle;
            txtstock.Font = new Font("Calibri", 9.75F);
            txtstock.Location = new Point(73, 116);
            txtstock.Name = "txtstock";
            txtstock.Size = new Size(53, 23);
            txtstock.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Schoolbook", 12F);
            label7.Location = new Point(18, 116);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 5;
            label7.Text = "Stock:";
            // 
            // txtcostoU
            // 
            txtcostoU.BackColor = Color.Ivory;
            txtcostoU.BorderStyle = BorderStyle.FixedSingle;
            txtcostoU.Font = new Font("Calibri", 9.75F);
            txtcostoU.Location = new Point(420, 86);
            txtcostoU.Name = "txtcostoU";
            txtcostoU.Size = new Size(60, 23);
            txtcostoU.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Schoolbook", 12F);
            label8.Location = new Point(293, 86);
            label8.Name = "label8";
            label8.Size = new Size(121, 20);
            label8.TabIndex = 3;
            label8.Text = "Costo Unitario:";
            // 
            // txtproducto
            // 
            txtproducto.BackColor = Color.Ivory;
            txtproducto.BorderStyle = BorderStyle.FixedSingle;
            txtproducto.Font = new Font("Calibri", 9.75F);
            txtproducto.Location = new Point(92, 46);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(177, 23);
            txtproducto.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Century Schoolbook", 12F);
            label9.Location = new Point(16, 46);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 1;
            label9.Text = "Producto:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(dateTimeFecha);
            groupBox1.Controls.Add(txtdescripcion);
            groupBox1.Controls.Add(Eliminar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtmarca);
            groupBox1.Controls.Add(txtproveedor);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtstock);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtcostoU);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtproducto);
            groupBox1.Controls.Add(label9);
            groupBox1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(22, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(744, 210);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Productos";
            // 
            // dateTimeFecha
            // 
            dateTimeFecha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimeFecha.Location = new Point(357, 46);
            dateTimeFecha.Name = "dateTimeFecha";
            dateTimeFecha.Size = new Size(193, 26);
            dateTimeFecha.TabIndex = 23;
            // 
            // txtdescripcion
            // 
            txtdescripcion.BackColor = Color.Ivory;
            txtdescripcion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdescripcion.Location = new Point(293, 143);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(309, 26);
            txtdescripcion.TabIndex = 22;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(30, 9);
            lblFecha.Margin = new Padding(5, 0, 5, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(69, 20);
            lblFecha.TabIndex = 21;
            lblFecha.Text = "lblFecha";
            // 
            // ViewProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = InventarioR.Properties.Resources.bground;
            ClientSize = new Size(780, 532);
            Controls.Add(dgvProductos);
            Controls.Add(lblFecha);
            Controls.Add(groupBox1);
            Name = "ViewProducts";
            Text = "ViewProducts";
            Load += ViewProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvProductos;
        private Button Eliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label label2;
        private TextBox txtmarca;
        private TextBox txtproveedor;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtstock;
        private Label label7;
        private TextBox txtcostoU;
        private Label label8;
        private TextBox txtproducto;
        private Label label9;
        private GroupBox groupBox1;
        private TextBox txtdescripcion;
        private Label lblFecha;
        private DateTimePicker dateTimeFecha;
        private DataGridViewTextBoxColumn ColumnProducto;
        private DataGridViewTextBoxColumn ColumnProveedor;
        private DataGridViewTextBoxColumn ColumnMarca;
        private DataGridViewTextBoxColumn ColumnStock;
        private DataGridViewTextBoxColumn ColumnCosto;
        private DataGridViewTextBoxColumn ColumnDescripcion;
    }
}