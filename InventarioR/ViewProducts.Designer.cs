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
            components = new System.ComponentModel.Container();
            dgvProductos = new DataGridView();
            ColumnProducto = new DataGridViewTextBoxColumn();
            ColumnProveedor = new DataGridViewTextBoxColumn();
            ColumnMarca = new DataGridViewTextBoxColumn();
            ColumnStock = new DataGridViewTextBoxColumn();
            ColumnFecha = new DataGridViewTextBoxColumn();
            ColumnCosto = new DataGridViewTextBoxColumn();
            ColumnDescripcion = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.BackgroundColor = Color.Silver;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { ColumnProducto, ColumnProveedor, ColumnMarca, ColumnStock, ColumnFecha, ColumnCosto, ColumnDescripcion });
            dgvProductos.Location = new Point(22, 266);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(744, 254);
            dgvProductos.TabIndex = 20;
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
            // ColumnFecha
            // 
            ColumnFecha.HeaderText = "Fecha";
            ColumnFecha.Name = "ColumnFecha";
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
            // textBox1
            // 
            textBox1.BackColor = Color.Ivory;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Calibri", 9.75F);
            textBox1.Location = new Point(460, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 23);
            textBox1.TabIndex = 21;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(167, 255, 132);
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(726, 130);
            button1.Name = "button1";
            button1.Size = new Size(85, 33);
            button1.TabIndex = 20;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(167, 255, 132);
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(726, 83);
            button2.Name = "button2";
            button2.Size = new Size(85, 33);
            button2.TabIndex = 19;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(167, 255, 132);
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(726, 34);
            button3.Name = "button3";
            button3.Size = new Size(85, 33);
            button3.TabIndex = 18;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = false;
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
            // textBox3
            // 
            textBox3.BackColor = Color.Ivory;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Calibri", 9.75F);
            textBox3.Location = new Point(83, 151);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(109, 23);
            textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Ivory;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Calibri", 9.75F);
            textBox4.Location = new Point(101, 83);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(144, 23);
            textBox4.TabIndex = 13;
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
            label5.Location = new Point(396, 44);
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
            label6.Location = new Point(396, 114);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 7;
            label6.Text = "Descripcion:";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Ivory;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Calibri", 9.75F);
            textBox6.Location = new Point(73, 116);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(53, 23);
            textBox6.TabIndex = 6;
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
            // textBox7
            // 
            textBox7.BackColor = Color.Ivory;
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Font = new Font("Calibri", 9.75F);
            textBox7.Location = new Point(523, 83);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(60, 23);
            textBox7.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Schoolbook", 12F);
            label8.Location = new Point(396, 83);
            label8.Name = "label8";
            label8.Size = new Size(121, 20);
            label8.TabIndex = 3;
            label8.Text = "Costo Unitario:";
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.Ivory;
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Font = new Font("Calibri", 9.75F);
            textBox8.Location = new Point(92, 46);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(177, 23);
            textBox8.TabIndex = 2;
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
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(label9);
            groupBox1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(22, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(820, 210);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Productos";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Ivory;
            textBox2.Location = new Point(396, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 47);
            textBox2.TabIndex = 22;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ViewProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = InventarioR.Properties.Resources.bground;
            ClientSize = new Size(849, 532);
            Controls.Add(dgvProductos);
            Controls.Add(groupBox1);
            Name = "ViewProducts";
            Text = "ViewProducts";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvProductos;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox8;
        private Label label9;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn ColumnProducto;
        private DataGridViewTextBoxColumn ColumnProveedor;
        private DataGridViewTextBoxColumn ColumnMarca;
        private DataGridViewTextBoxColumn ColumnStock;
        private DataGridViewTextBoxColumn ColumnFecha;
        private DataGridViewTextBoxColumn ColumnCosto;
        private DataGridViewTextBoxColumn ColumnDescripcion;
        private TextBox textBox2;
        private ContextMenuStrip contextMenuStrip1;
    }
}