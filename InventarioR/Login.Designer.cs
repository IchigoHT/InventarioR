namespace InventarioR
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnlogin = new Button();
            txtpass = new TextBox();
            label2 = new Label();
            txtuser = new TextBox();
            label1 = new Label();
            label3 = new Label();
            btnminimizar = new PictureBox();
            btncerrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            SuspendLayout();
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(40, 40, 40);
            btnlogin.FlatAppearance.BorderSize = 0;
            btnlogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnlogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.ForeColor = Color.LightGray;
            btnlogin.Location = new Point(41, 421);
            btnlogin.Name = "btnlogin";
            btnlogin.RightToLeft = RightToLeft.Yes;
            btnlogin.Size = new Size(260, 39);
            btnlogin.TabIndex = 21;
            btnlogin.Text = "ACCEDER";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.FromArgb(15, 15, 15);
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.ForeColor = SystemColors.WindowFrame;
            txtpass.Location = new Point(38, 333);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(259, 20);
            txtpass.TabIndex = 20;
            txtpass.Text = "Contraseña";
            txtpass.Enter += txtpass_Enter;
            txtpass.Leave += txtpass_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(15, 15, 15);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(37, 345);
            label2.Name = "label2";
            label2.Size = new Size(262, 15);
            label2.TabIndex = 19;
            label2.Text = "___________________________________________________";
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.FromArgb(15, 15, 15);
            txtuser.BorderStyle = BorderStyle.None;
            txtuser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.ForeColor = SystemColors.WindowFrame;
            txtuser.Location = new Point(41, 257);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(259, 20);
            txtuser.TabIndex = 18;
            txtuser.Text = "Usuario";
            txtuser.Enter += txtuser_Enter;
            txtuser.Leave += txtuser_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(15, 15, 15);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(38, 268);
            label1.Name = "label1";
            label1.Size = new Size(262, 15);
            label1.TabIndex = 17;
            label1.Text = "___________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(117, 109);
            label3.Name = "label3";
            label3.Size = new Size(120, 39);
            label3.TabIndex = 16;
            label3.Text = "LOGIN";
            // 
            // btnminimizar
            // 
            btnminimizar.Image = (Image)resources.GetObject("btnminimizar.Image");
            btnminimizar.Location = new Point(270, 12);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(22, 20);
            btnminimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnminimizar.TabIndex = 23;
            btnminimizar.TabStop = false;
            btnminimizar.Click += btnminimizar_Click;
            // 
            // btncerrar
            // 
            btncerrar.Image = (Image)resources.GetObject("btncerrar.Image");
            btncerrar.Location = new Point(307, 12);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(20, 20);
            btncerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btncerrar.TabIndex = 22;
            btncerrar.TabStop = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(339, 568);
            Controls.Add(btnminimizar);
            Controls.Add(btncerrar);
            Controls.Add(btnlogin);
            Controls.Add(txtpass);
            Controls.Add(label2);
            Controls.Add(txtuser);
            Controls.Add(label1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            MouseDown += Login_MouseDown;
            ((System.ComponentModel.ISupportInitialize)btnminimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlogin;
        private TextBox txtpass;
        private Label label2;
        private TextBox txtuser;
        private Label label1;
        private Label label3;
        private PictureBox btnminimizar;
        private PictureBox btncerrar;
    }
}