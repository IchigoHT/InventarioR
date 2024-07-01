namespace Proveedores_Oficial
{
    partial class Proveedores
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
            dgvProveedores = new DataGridView();
            ColumnNombreEmpresa = new DataGridViewTextBoxColumn();
            ColumnProductosOfrecidos = new DataGridViewTextBoxColumn();
            ColumnNombreContacto = new DataGridViewTextBoxColumn();
            ColumnDNI = new DataGridViewTextBoxColumn();
            ColumnCelular = new DataGridViewTextBoxColumn();
            ColumnCorreo = new DataGridViewTextBoxColumn();
            ColumnDirección = new DataGridViewTextBoxColumn();
            ColumnSitioWeb = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            lblEmpresa = new Label();
            txtEmpresa = new TextBox();
            lblDNI = new Label();
            txtDNI = new TextBox();
            lblCelular = new Label();
            txtCelular = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblProductos = new Label();
            lblContacto = new Label();
            txtNombreContacto = new TextBox();
            txtDirección = new TextBox();
            lblSitioWeb = new Label();
            txtSitioWeb = new TextBox();
            lblDirección = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            txtProductos = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProveedores
            // 
            dgvProveedores.BackgroundColor = Color.Silver;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Columns.AddRange(new DataGridViewColumn[] { ColumnNombreEmpresa, ColumnProductosOfrecidos, ColumnNombreContacto, ColumnDNI, ColumnCelular, ColumnCorreo, ColumnDirección, ColumnSitioWeb });
            dgvProveedores.Location = new Point(27, 220);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.Size = new Size(894, 269);
            dgvProveedores.TabIndex = 19;
            dgvProveedores.CellContentClick += dgvProveedores_CellContentClick;
            // 
            // ColumnNombreEmpresa
            // 
            ColumnNombreEmpresa.HeaderText = "Nombre de la empresa";
            ColumnNombreEmpresa.Name = "ColumnNombreEmpresa";
            // 
            // ColumnProductosOfrecidos
            // 
            ColumnProductosOfrecidos.HeaderText = "Productos ofrecidos";
            ColumnProductosOfrecidos.Name = "ColumnProductosOfrecidos";
            // 
            // ColumnNombreContacto
            // 
            ColumnNombreContacto.HeaderText = "Nombre de contacto";
            ColumnNombreContacto.Name = "ColumnNombreContacto";
            // 
            // ColumnDNI
            // 
            ColumnDNI.HeaderText = "DNI";
            ColumnDNI.Name = "ColumnDNI";
            // 
            // ColumnCelular
            // 
            ColumnCelular.HeaderText = "Celular";
            ColumnCelular.Name = "ColumnCelular";
            // 
            // ColumnCorreo
            // 
            ColumnCorreo.HeaderText = "Correo";
            ColumnCorreo.Name = "ColumnCorreo";
            // 
            // ColumnDirección
            // 
            ColumnDirección.HeaderText = "Dirección";
            ColumnDirección.Name = "ColumnDirección";
            // 
            // ColumnSitioWeb
            // 
            ColumnSitioWeb.HeaderText = "Sitio Web";
            ColumnSitioWeb.Name = "ColumnSitioWeb";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtProductos);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(lblDirección);
            groupBox1.Controls.Add(txtSitioWeb);
            groupBox1.Controls.Add(lblSitioWeb);
            groupBox1.Controls.Add(txtDirección);
            groupBox1.Controls.Add(txtNombreContacto);
            groupBox1.Controls.Add(lblContacto);
            groupBox1.Controls.Add(lblProductos);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(lblCorreo);
            groupBox1.Controls.Add(txtCelular);
            groupBox1.Controls.Add(lblCelular);
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(lblDNI);
            groupBox1.Controls.Add(txtEmpresa);
            groupBox1.Controls.Add(lblEmpresa);
            groupBox1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(23, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(898, 182);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Proveedores";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Ivory;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Calibri", 9.75F);
            textBox1.Location = new Point(657, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 21;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(167, 255, 132);
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(807, 132);
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
            button2.Location = new Point(807, 85);
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
            button3.Location = new Point(807, 36);
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
            label2.Location = new Point(16, 140);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 17;
            label2.Text = "Dirección:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Ivory;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Calibri", 9.75F);
            textBox2.Location = new Point(538, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 23);
            textBox2.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Schoolbook", 12F);
            label3.Location = new Point(448, 145);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 15;
            label3.Text = "Sitio Web:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Ivory;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Calibri", 9.75F);
            textBox3.Location = new Point(104, 140);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(301, 23);
            textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Ivory;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Calibri", 9.75F);
            textBox4.Location = new Point(171, 80);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(298, 23);
            textBox4.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Schoolbook", 12F);
            label4.Location = new Point(16, 78);
            label4.Name = "label4";
            label4.Size = new Size(158, 20);
            label4.TabIndex = 12;
            label4.Text = "Nombre de contacto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Schoolbook", 12F);
            label5.Location = new Point(504, 44);
            label5.Name = "label5";
            label5.Size = new Size(154, 20);
            label5.TabIndex = 9;
            label5.Text = "Productos ofrecidos:";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Ivory;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Calibri", 9.75F);
            textBox5.Location = new Point(573, 113);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(218, 23);
            textBox5.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Schoolbook", 12F);
            label6.Location = new Point(504, 114);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 7;
            label6.Text = "Correo:";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Ivory;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Calibri", 9.75F);
            textBox6.Location = new Point(90, 111);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(123, 23);
            textBox6.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Schoolbook", 12F);
            label7.Location = new Point(15, 111);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 5;
            label7.Text = "Celular:";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.Ivory;
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Font = new Font("Calibri", 9.75F);
            textBox7.Location = new Point(609, 80);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(182, 23);
            textBox7.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Schoolbook", 12F);
            label8.Location = new Point(558, 80);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 3;
            label8.Text = "DNI:";
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.Ivory;
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Font = new Font("Calibri", 9.75F);
            textBox8.Location = new Point(190, 46);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(279, 23);
            textBox8.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Century Schoolbook", 12F);
            label9.Location = new Point(16, 46);
            label9.Name = "label9";
            label9.Size = new Size(177, 20);
            label9.TabIndex = 1;
            label9.Text = "Nombre de la empresa:";
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.BackColor = Color.Transparent;
            lblEmpresa.Font = new Font("Century Schoolbook", 12F);
            lblEmpresa.Location = new Point(16, 46);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(177, 20);
            lblEmpresa.TabIndex = 1;
            lblEmpresa.Text = "Nombre de la empresa:";
            // 
            // txtEmpresa
            // 
            txtEmpresa.BackColor = Color.Ivory;
            txtEmpresa.BorderStyle = BorderStyle.FixedSingle;
            txtEmpresa.Font = new Font("Calibri", 9.75F);
            txtEmpresa.Location = new Point(190, 46);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(279, 23);
            txtEmpresa.TabIndex = 2;
            txtEmpresa.TextChanged += txtNombre_TextChanged;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.BackColor = Color.Transparent;
            lblDNI.Font = new Font("Century Schoolbook", 12F);
            lblDNI.Location = new Point(558, 80);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(45, 20);
            lblDNI.TabIndex = 3;
            lblDNI.Text = "DNI:";
            // 
            // txtDNI
            // 
            txtDNI.BackColor = Color.Ivory;
            txtDNI.BorderStyle = BorderStyle.FixedSingle;
            txtDNI.Font = new Font("Calibri", 9.75F);
            txtDNI.Location = new Point(609, 80);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(182, 23);
            txtDNI.TabIndex = 4;
            txtDNI.TextChanged += txtDNI_TextChanged;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.BackColor = Color.Transparent;
            lblCelular.Font = new Font("Century Schoolbook", 12F);
            lblCelular.Location = new Point(15, 111);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(69, 20);
            lblCelular.TabIndex = 5;
            lblCelular.Text = "Celular:";
            // 
            // txtCelular
            // 
            txtCelular.BackColor = Color.Ivory;
            txtCelular.BorderStyle = BorderStyle.FixedSingle;
            txtCelular.Font = new Font("Calibri", 9.75F);
            txtCelular.Location = new Point(90, 111);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(123, 23);
            txtCelular.TabIndex = 6;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = Color.Transparent;
            lblCorreo.Font = new Font("Century Schoolbook", 12F);
            lblCorreo.Location = new Point(504, 114);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(63, 20);
            lblCorreo.TabIndex = 7;
            lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.Ivory;
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Font = new Font("Calibri", 9.75F);
            txtCorreo.Location = new Point(573, 113);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(218, 23);
            txtCorreo.TabIndex = 8;
            txtCorreo.TextChanged += textBox2_TextChanged;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.BackColor = Color.Transparent;
            lblProductos.Font = new Font("Century Schoolbook", 12F);
            lblProductos.Location = new Point(504, 44);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(154, 20);
            lblProductos.TabIndex = 9;
            lblProductos.Text = "Productos ofrecidos:";
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.BackColor = Color.Transparent;
            lblContacto.Font = new Font("Century Schoolbook", 12F);
            lblContacto.Location = new Point(16, 78);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(158, 20);
            lblContacto.TabIndex = 12;
            lblContacto.Text = "Nombre de contacto:";
            // 
            // txtNombreContacto
            // 
            txtNombreContacto.BackColor = Color.Ivory;
            txtNombreContacto.BorderStyle = BorderStyle.FixedSingle;
            txtNombreContacto.Font = new Font("Calibri", 9.75F);
            txtNombreContacto.Location = new Point(171, 80);
            txtNombreContacto.Name = "txtNombreContacto";
            txtNombreContacto.Size = new Size(298, 23);
            txtNombreContacto.TabIndex = 13;
            txtNombreContacto.TextChanged += txtNombreContacto_TextChanged;
            // 
            // txtDirección
            // 
            txtDirección.BackColor = Color.Ivory;
            txtDirección.BorderStyle = BorderStyle.FixedSingle;
            txtDirección.Font = new Font("Calibri", 9.75F);
            txtDirección.Location = new Point(104, 140);
            txtDirección.Name = "txtDirección";
            txtDirección.Size = new Size(301, 23);
            txtDirección.TabIndex = 14;
            // 
            // lblSitioWeb
            // 
            lblSitioWeb.AutoSize = true;
            lblSitioWeb.BackColor = Color.Transparent;
            lblSitioWeb.Font = new Font("Century Schoolbook", 12F);
            lblSitioWeb.Location = new Point(448, 145);
            lblSitioWeb.Name = "lblSitioWeb";
            lblSitioWeb.Size = new Size(84, 20);
            lblSitioWeb.TabIndex = 15;
            lblSitioWeb.Text = "Sitio Web:";
            lblSitioWeb.Click += label8_Click;
            // 
            // txtSitioWeb
            // 
            txtSitioWeb.BackColor = Color.Ivory;
            txtSitioWeb.BorderStyle = BorderStyle.FixedSingle;
            txtSitioWeb.Font = new Font("Calibri", 9.75F);
            txtSitioWeb.Location = new Point(538, 142);
            txtSitioWeb.Name = "txtSitioWeb";
            txtSitioWeb.Size = new Size(253, 23);
            txtSitioWeb.TabIndex = 16;
            // 
            // lblDirección
            // 
            lblDirección.AutoSize = true;
            lblDirección.BackColor = Color.Transparent;
            lblDirección.Font = new Font("Century Schoolbook", 12F);
            lblDirección.Location = new Point(16, 140);
            lblDirección.Name = "lblDirección";
            lblDirección.Size = new Size(82, 20);
            lblDirección.TabIndex = 17;
            lblDirección.Text = "Dirección:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(167, 255, 132);
            btnAgregar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(807, 36);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(85, 33);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(167, 255, 132);
            btnModificar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(807, 85);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(85, 33);
            btnModificar.TabIndex = 19;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(167, 255, 132);
            btnEliminar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(807, 132);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(85, 33);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtProductos
            // 
            txtProductos.BackColor = Color.Ivory;
            txtProductos.BorderStyle = BorderStyle.FixedSingle;
            txtProductos.Font = new Font("Calibri", 9.75F);
            txtProductos.Location = new Point(657, 43);
            txtProductos.Name = "txtProductos";
            txtProductos.Size = new Size(134, 23);
            txtProductos.TabIndex = 21;
            txtProductos.TextChanged += txtProductos_TextChanged;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = InventarioR.Properties.Resources.bground;
            ClientSize = new Size(944, 501);
            Controls.Add(dgvProveedores);
            Controls.Add(groupBox1);
            Name = "Proveedores";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvProveedores;
        private DataGridViewTextBoxColumn ColumnNombreEmpresa;
        private DataGridViewTextBoxColumn ColumnProductosOfrecidos;
        private DataGridViewTextBoxColumn ColumnNombreContacto;
        private DataGridViewTextBoxColumn ColumnDNI;
        private DataGridViewTextBoxColumn ColumnCelular;
        private DataGridViewTextBoxColumn ColumnCorreo;
        private DataGridViewTextBoxColumn ColumnDirección;
        private DataGridViewTextBoxColumn ColumnSitioWeb;
        private GroupBox groupBox1;
        private TextBox txtProductos;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label lblDirección;
        private TextBox txtSitioWeb;
        private Label lblSitioWeb;
        private TextBox txtDirección;
        private TextBox txtNombreContacto;
        private Label lblContacto;
        private Label lblProductos;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private TextBox txtCelular;
        private Label lblCelular;
        private TextBox txtDNI;
        private Label lblDNI;
        private TextBox txtEmpresa;
        private Label lblEmpresa;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox8;
        private Label label9;
    }
}
