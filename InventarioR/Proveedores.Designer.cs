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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            GroupBox1 = new GroupBox();
            TxtProductos = new TextBox();
            BtnEliminar = new Button();
            BtnModificar = new Button();
            BtnAgregar = new Button();
            LblDirección = new Label();
            TxtSitioWeb = new TextBox();
            LblSitioWeb = new Label();
            TxtDirección = new TextBox();
            TxtNombreContacto = new TextBox();
            LblContacto = new Label();
            LblProductos = new Label();
            TxtCorreo = new TextBox();
            LblCorreo = new Label();
            TxtCelular = new TextBox();
            LblCelular = new Label();
            TxtDNI = new TextBox();
            LblDNI = new Label();
            TxtEmpresa = new TextBox();
            LblEmpresa = new Label();
            DgvProveedores = new DataGridView();
            ColumnNombreEmpresa = new DataGridViewTextBoxColumn();
            ColumnProductosOfrecidos = new DataGridViewTextBoxColumn();
            ColumnNombreContacto = new DataGridViewTextBoxColumn();
            ColumnDNI = new DataGridViewTextBoxColumn();
            ColumnCelular = new DataGridViewTextBoxColumn();
            ColumnCorreo = new DataGridViewTextBoxColumn();
            ColumnDirección = new DataGridViewTextBoxColumn();
            ColumnSitioWeb = new DataGridViewTextBoxColumn();
            GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // GroupBox1
            // 
            GroupBox1.BackColor = Color.Transparent;
            GroupBox1.Controls.Add(TxtProductos);
            GroupBox1.Controls.Add(BtnEliminar);
            GroupBox1.Controls.Add(BtnModificar);
            GroupBox1.Controls.Add(BtnAgregar);
            GroupBox1.Controls.Add(LblDirección);
            GroupBox1.Controls.Add(TxtSitioWeb);
            GroupBox1.Controls.Add(LblSitioWeb);
            GroupBox1.Controls.Add(TxtDirección);
            GroupBox1.Controls.Add(TxtNombreContacto);
            GroupBox1.Controls.Add(LblContacto);
            GroupBox1.Controls.Add(LblProductos);
            GroupBox1.Controls.Add(TxtCorreo);
            GroupBox1.Controls.Add(LblCorreo);
            GroupBox1.Controls.Add(TxtCelular);
            GroupBox1.Controls.Add(LblCelular);
            GroupBox1.Controls.Add(TxtDNI);
            GroupBox1.Controls.Add(LblDNI);
            GroupBox1.Controls.Add(TxtEmpresa);
            GroupBox1.Controls.Add(LblEmpresa);
            GroupBox1.Font = new Font("Milk Kids", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBox1.Location = new Point(23, 21);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(898, 182);
            GroupBox1.TabIndex = 1;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Proveedores";
            // 
            // TxtProductos
            // 
            TxtProductos.BackColor = Color.Ivory;
            TxtProductos.BorderStyle = BorderStyle.FixedSingle;
            TxtProductos.Font = new Font("Calibri", 9.75F);
            TxtProductos.Location = new Point(657, 43);
            TxtProductos.Name = "TxtProductos";
            TxtProductos.Size = new Size(134, 23);
            TxtProductos.TabIndex = 21;
            TxtProductos.TextChanged += TxtProductos_TextChanged;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.FromArgb(167, 255, 132);
            BtnEliminar.Font = new Font("Milk Kids", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEliminar.ForeColor = Color.Black;
            BtnEliminar.Location = new Point(807, 132);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(85, 33);
            BtnEliminar.TabIndex = 20;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.BackColor = Color.FromArgb(167, 255, 132);
            BtnModificar.Font = new Font("Milk Kids", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnModificar.ForeColor = Color.Black;
            BtnModificar.Location = new Point(807, 85);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(85, 33);
            BtnModificar.TabIndex = 19;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = false;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.FromArgb(167, 255, 132);
            BtnAgregar.Font = new Font("Milk Kids", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAgregar.ForeColor = Color.Black;
            BtnAgregar.Location = new Point(807, 36);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(85, 33);
            BtnAgregar.TabIndex = 18;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // LblDirección
            // 
            LblDirección.AutoSize = true;
            LblDirección.BackColor = Color.Transparent;
            LblDirección.Font = new Font("Century Schoolbook", 12F);
            LblDirección.Location = new Point(16, 140);
            LblDirección.Name = "LblDirección";
            LblDirección.Size = new Size(82, 20);
            LblDirección.TabIndex = 17;
            LblDirección.Text = "Dirección:";
            // 
            // TxtSitioWeb
            // 
            TxtSitioWeb.BackColor = Color.Ivory;
            TxtSitioWeb.BorderStyle = BorderStyle.FixedSingle;
            TxtSitioWeb.Font = new Font("Calibri", 9.75F);
            TxtSitioWeb.Location = new Point(538, 142);
            TxtSitioWeb.Name = "TxtSitioWeb";
            TxtSitioWeb.Size = new Size(253, 23);
            TxtSitioWeb.TabIndex = 16;
            TxtSitioWeb.TextChanged += TxtSitioWeb_TextChanged;
            // 
            // LblSitioWeb
            // 
            LblSitioWeb.AutoSize = true;
            LblSitioWeb.BackColor = Color.Transparent;
            LblSitioWeb.Font = new Font("Century Schoolbook", 12F);
            LblSitioWeb.Location = new Point(448, 145);
            LblSitioWeb.Name = "LblSitioWeb";
            LblSitioWeb.Size = new Size(84, 20);
            LblSitioWeb.TabIndex = 15;
            LblSitioWeb.Text = "Sitio Web:";
            LblSitioWeb.Click += LblSitioWeb_Click;
            // 
            // TxtDirección
            // 
            TxtDirección.BackColor = Color.Ivory;
            TxtDirección.BorderStyle = BorderStyle.FixedSingle;
            TxtDirección.Font = new Font("Calibri", 9.75F);
            TxtDirección.Location = new Point(104, 140);
            TxtDirección.Name = "TxtDirección";
            TxtDirección.Size = new Size(301, 23);
            TxtDirección.TabIndex = 14;
            // 
            // TxtNombreContacto
            // 
            TxtNombreContacto.BackColor = Color.Ivory;
            TxtNombreContacto.BorderStyle = BorderStyle.FixedSingle;
            TxtNombreContacto.Font = new Font("Calibri", 9.75F);
            TxtNombreContacto.Location = new Point(171, 80);
            TxtNombreContacto.Name = "TxtNombreContacto";
            TxtNombreContacto.Size = new Size(298, 23);
            TxtNombreContacto.TabIndex = 13;
            TxtNombreContacto.TextChanged += TxtNombreContacto_TextChanged;
            // 
            // LblContacto
            // 
            LblContacto.AutoSize = true;
            LblContacto.BackColor = Color.Transparent;
            LblContacto.Font = new Font("Century Schoolbook", 12F);
            LblContacto.Location = new Point(16, 78);
            LblContacto.Name = "LblContacto";
            LblContacto.Size = new Size(158, 20);
            LblContacto.TabIndex = 12;
            LblContacto.Text = "Nombre de contacto:";
            // 
            // LblProductos
            // 
            LblProductos.AutoSize = true;
            LblProductos.BackColor = Color.Transparent;
            LblProductos.Font = new Font("Century Schoolbook", 12F);
            LblProductos.Location = new Point(504, 44);
            LblProductos.Name = "LblProductos";
            LblProductos.Size = new Size(154, 20);
            LblProductos.TabIndex = 9;
            LblProductos.Text = "Productos ofrecidos:";
            // 
            // TxtCorreo
            // 
            TxtCorreo.BackColor = Color.Ivory;
            TxtCorreo.BorderStyle = BorderStyle.FixedSingle;
            TxtCorreo.Font = new Font("Calibri", 9.75F);
            TxtCorreo.Location = new Point(573, 113);
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.Size = new Size(218, 23);
            TxtCorreo.TabIndex = 8;
            TxtCorreo.TextChanged += TxtCorreo_TextChanged;
            // 
            // LblCorreo
            // 
            LblCorreo.AutoSize = true;
            LblCorreo.BackColor = Color.Transparent;
            LblCorreo.Font = new Font("Century Schoolbook", 12F);
            LblCorreo.Location = new Point(504, 114);
            LblCorreo.Name = "LblCorreo";
            LblCorreo.Size = new Size(63, 20);
            LblCorreo.TabIndex = 7;
            LblCorreo.Text = "Correo:";
            // 
            // TxtCelular
            // 
            TxtCelular.BackColor = Color.Ivory;
            TxtCelular.BorderStyle = BorderStyle.FixedSingle;
            TxtCelular.Font = new Font("Calibri", 9.75F);
            TxtCelular.Location = new Point(90, 111);
            TxtCelular.Name = "TxtCelular";
            TxtCelular.Size = new Size(123, 23);
            TxtCelular.TabIndex = 6;
            TxtCelular.TextChanged += TxtCelular_TextChanged;
            // 
            // LblCelular
            // 
            LblCelular.AutoSize = true;
            LblCelular.BackColor = Color.Transparent;
            LblCelular.Font = new Font("Century Schoolbook", 12F);
            LblCelular.Location = new Point(15, 111);
            LblCelular.Name = "LblCelular";
            LblCelular.Size = new Size(69, 20);
            LblCelular.TabIndex = 5;
            LblCelular.Text = "Celular:";
            // 
            // TxtDNI
            // 
            TxtDNI.BackColor = Color.Ivory;
            TxtDNI.BorderStyle = BorderStyle.FixedSingle;
            TxtDNI.Font = new Font("Calibri", 9.75F);
            TxtDNI.Location = new Point(609, 80);
            TxtDNI.Name = "TxtDNI";
            TxtDNI.Size = new Size(182, 23);
            TxtDNI.TabIndex = 4;
            TxtDNI.TextChanged += TxtDNI_TextChanged;
            // 
            // LblDNI
            // 
            LblDNI.AutoSize = true;
            LblDNI.BackColor = Color.Transparent;
            LblDNI.Font = new Font("Century Schoolbook", 12F);
            LblDNI.Location = new Point(558, 80);
            LblDNI.Name = "LblDNI";
            LblDNI.Size = new Size(45, 20);
            LblDNI.TabIndex = 3;
            LblDNI.Text = "DNI:";
            // 
            // TxtEmpresa
            // 
            TxtEmpresa.BackColor = Color.Ivory;
            TxtEmpresa.BorderStyle = BorderStyle.FixedSingle;
            TxtEmpresa.Font = new Font("Calibri", 9.75F);
            TxtEmpresa.Location = new Point(190, 46);
            TxtEmpresa.Name = "TxtEmpresa";
            TxtEmpresa.Size = new Size(279, 23);
            TxtEmpresa.TabIndex = 2;
            TxtEmpresa.TextChanged += TxtEmpresa_TextChanged;
            // 
            // LblEmpresa
            // 
            LblEmpresa.AutoSize = true;
            LblEmpresa.BackColor = Color.Transparent;
            LblEmpresa.Font = new Font("Century Schoolbook", 12F);
            LblEmpresa.Location = new Point(16, 46);
            LblEmpresa.Name = "LblEmpresa";
            LblEmpresa.Size = new Size(177, 20);
            LblEmpresa.TabIndex = 1;
            LblEmpresa.Text = "Nombre de la empresa:";
            LblEmpresa.Click += LblEmpresa_Click;
            // 
            // DgvProveedores
            // 
            DgvProveedores.BackgroundColor = Color.Silver;
            DgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProveedores.Columns.AddRange(new DataGridViewColumn[] { ColumnNombreEmpresa, ColumnProductosOfrecidos, ColumnNombreContacto, ColumnDNI, ColumnCelular, ColumnCorreo, ColumnDirección, ColumnSitioWeb });
            DgvProveedores.Location = new Point(27, 220);
            DgvProveedores.Name = "DgvProveedores";
            DgvProveedores.Size = new Size(894, 269);
            DgvProveedores.TabIndex = 19;
            DgvProveedores.CellContentClick += DgvProveedores_CellContentClick;
            // 
            // ColumnNombreEmpresa
            // 
            ColumnNombreEmpresa.HeaderText = "Nombre de la empresa";
            ColumnNombreEmpresa.Name = "ColumnNombreEmpresa";
            ColumnNombreEmpresa.Width = 106;
            // 
            // ColumnProductosOfrecidos
            // 
            ColumnProductosOfrecidos.FillWeight = 105F;
            ColumnProductosOfrecidos.HeaderText = "Productos ofrecidos";
            ColumnProductosOfrecidos.Name = "ColumnProductosOfrecidos";
            ColumnProductosOfrecidos.Width = 110;
            // 
            // ColumnNombreContacto
            // 
            ColumnNombreContacto.HeaderText = "Nombre de contacto";
            ColumnNombreContacto.Name = "ColumnNombreContacto";
            ColumnNombreContacto.Width = 105;
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
            ColumnCorreo.Width = 115;
            // 
            // ColumnDirección
            // 
            ColumnDirección.HeaderText = "Dirección";
            ColumnDirección.Name = "ColumnDirección";
            ColumnDirección.Width = 110;
            // 
            // ColumnSitioWeb
            // 
            ColumnSitioWeb.HeaderText = "Sitio Web";
            ColumnSitioWeb.Name = "ColumnSitioWeb";
            ColumnSitioWeb.Width = 106;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(944, 501);
            Controls.Add(DgvProveedores);
            Controls.Add(GroupBox1);
            Name = "Form1";
            Text = "Form1";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProveedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBox1;
        private Label LblDNI;
        private TextBox TxtEmpresa;
        private Label LblEmpresa;
        private TextBox TxtDNI;
        private TextBox TxtCorreo;
        private Label LblCorreo;
        private TextBox TxtCelular;
        private Label LblCelular;
        private Label LblProductos;
        private Label LblContacto;
        private TextBox TxtNombreContacto;
        private Label LblDirección;
        private TextBox TxtSitioWeb;
        private Label LblSitioWeb;
        private TextBox TxtDirección;
        private DataGridView DgvProveedores;
        private Button BtnAgregar;
        private Button BtnEliminar;
        private Button BtnModificar;
        private TextBox TxtProductos;
        private DataGridViewTextBoxColumn ColumnNombreEmpresa;
        private DataGridViewTextBoxColumn ColumnProductosOfrecidos;
        private DataGridViewTextBoxColumn ColumnNombreContacto;
        private DataGridViewTextBoxColumn ColumnDNI;
        private DataGridViewTextBoxColumn ColumnCelular;
        private DataGridViewTextBoxColumn ColumnCorreo;
        private DataGridViewTextBoxColumn ColumnDirección;
        private DataGridViewTextBoxColumn ColumnSitioWeb;
    }
}
