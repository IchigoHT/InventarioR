namespace Proveedores_Oficial
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
            dgvProveedores.AllowUserToAddRows = false;  // Eliminar la fila en blanco predeterminada
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtEmpresa.Text != "" && txtProductos.Text != "" && txtNombreContacto.Text != "" && txtDNI.Text != "" && txtCorreo.Text != "" && txtCelular.Text != "" && txtDirección.Text != "")
            {
                dgvProveedores.Rows.Add(txtEmpresa.Text, txtProductos.Text, txtNombreContacto.Text, txtDNI.Text, txtCelular.Text, txtCorreo.Text, txtDirección.Text, txtSitioWeb.Text);
                limpiarDatos();
            }
            else
            {
                MessageBox.Show("Agregar datos");
            }
        }

        void limpiarDatos()
        {
            txtEmpresa.Text = "";
            txtProductos.Text = "";
            txtNombreContacto.Text = "";
            txtDNI.Text = "";
            txtCelular.Text = "";
            txtCorreo.Text = "";
            txtDirección.Text = "";
            txtSitioWeb.Text = "";
        }

        private void txtNombreContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvProveedores.Rows[e.RowIndex];
                txtEmpresa.Text = selectedRow.Cells[0].Value.ToString();
                txtProductos.Text = selectedRow.Cells[1].Value.ToString();
                txtNombreContacto.Text = selectedRow.Cells[2].Value.ToString();
                txtDNI.Text = selectedRow.Cells[3].Value.ToString();
                txtCelular.Text = selectedRow.Cells[4].Value.ToString();
                txtCorreo.Text = selectedRow.Cells[5].Value.ToString();
                txtDirección.Text = selectedRow.Cells[6].Value.ToString();
                txtSitioWeb.Text = selectedRow.Cells[7].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProveedores.SelectedRows[0];

                selectedRow.Cells[0].Value = txtEmpresa.Text;
                selectedRow.Cells[1].Value = txtProductos.Text;
                selectedRow.Cells[2].Value = txtNombreContacto.Text;
                selectedRow.Cells[3].Value = txtDNI.Text;
                selectedRow.Cells[4].Value = txtCelular.Text;
                selectedRow.Cells[5].Value = txtCorreo.Text;
                selectedRow.Cells[6].Value = txtDirección.Text;
                selectedRow.Cells[7].Value = txtSitioWeb.Text;

                limpiarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                dgvProveedores.Rows.RemoveAt(dgvProveedores.SelectedRows[0].Index);
                limpiarDatos();
            } 
        }

        private void txtProductos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
