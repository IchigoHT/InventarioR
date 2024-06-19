namespace TRABAJOT3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            CboProducto = new ComboBox();
            label9 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            CboMedio = new ComboBox();
            label7 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            lblFecha = new Label();
            label10 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(167, 255, 132);
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 7);
            label1.Name = "label1";
            label1.Size = new Size(212, 28);
            label1.TabIndex = 0;
            label1.Text = "REALIZAR COMPRA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 17);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "NOMBRES";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 178);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "EMAIL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 99);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 3;
            label4.Text = "DNI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 139);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 4;
            label5.Text = "TELEFONO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 132);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(CboProducto);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(CboMedio);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(20, 48);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(485, 307);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "CLIENTE";
            // 
            // CboProducto
            // 
            CboProducto.FormattingEnabled = true;
            CboProducto.Items.AddRange(new object[] { "Mueble Amarillo", "Mueble Rosado", "Mueble Blanco" });
            CboProducto.Location = new Point(18, 235);
            CboProducto.Margin = new Padding(3, 2, 3, 2);
            CboProducto.Name = "CboProducto";
            CboProducto.Size = new Size(409, 23);
            CboProducto.TabIndex = 15;
            CboProducto.SelectedIndexChanged += CboProducto_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 57);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 14;
            label9.Text = "APELLIDOS";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(18, 196);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(409, 23);
            textBox5.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 218);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 12;
            label8.Text = "PRODUCTO";
            // 
            // CboMedio
            // 
            CboMedio.FormattingEnabled = true;
            CboMedio.Items.AddRange(new object[] { "Contado", "Credito" });
            CboMedio.Location = new Point(18, 275);
            CboMedio.Margin = new Padding(3, 2, 3, 2);
            CboMedio.Name = "CboMedio";
            CboMedio.Size = new Size(409, 23);
            CboMedio.TabIndex = 11;
            CboMedio.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 258);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 10;
            label7.Text = "TIPO DE PAGO";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(18, 156);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(409, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(18, 116);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(409, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(18, 76);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(409, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 34);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(409, 23);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Location = new Point(515, 261);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(158, 43);
            button1.TabIndex = 8;
            button1.Text = "VOLVER";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            button2.Location = new Point(515, 312);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(158, 43);
            button2.TabIndex = 9;
            button2.Text = "COMPRAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(167, 255, 132);
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listView1.GridLines = true;
            listView1.Location = new Point(20, 373);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(653, 274);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "NOMBRES";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "APELLIDOS";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "DNI";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "TELEFONO";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "EMAIL";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "PRODUCTO";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "MEDIO DE PAGO";
            columnHeader7.Width = 150;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.FromArgb(22, 184, 119);
            lblFecha.Location = new Point(634, 124);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(51, 15);
            lblFecha.TabIndex = 11;
            lblFecha.Text = "lblFecha";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(22, 184, 119);
            label10.Location = new Point(528, 124);
            label10.Name = "label10";
            label10.Size = new Size(94, 15);
            label10.TabIndex = 12;
            label10.Text = "FECHA ACTUAL:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 25, 84);
            BackgroundImage = InventarioR.Properties.Resources.bground;
            ClientSize = new Size(727, 655);
            Controls.Add(label10);
            Controls.Add(lblFecha);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "COMPRAR";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private ComboBox CboMedio;
        private Label label7;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label8;
        private TextBox textBox5;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label label9;
        private Label lblFecha;
        private Label label10;
        private ComboBox CboProducto;
    }
}
