namespace Proveedores_Oficial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DgvProveedores.AllowUserToAddRows = false;  // Eliminar la fila en blanco predeterminada
            CargarDatos();
        }


        void LimpiarDatos()
        {
            TxtEmpresa.Text = "";
            TxtProductos.Text = "";
            TxtNombreContacto.Text = "";
            TxtDNI.Text = "";
            TxtCelular.Text = "";
            TxtCorreo.Text = "";
            TxtDirección.Text = "";
            TxtSitioWeb.Text = "";
        }
        //private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void TxtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblSitioWeb_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Comprobar si todos los campos requeridos están llenos
            if (TxtEmpresa.Text != "" && TxtProductos.Text != "" && TxtNombreContacto.Text != "" && TxtDNI.Text != "" && TxtCorreo.Text != "" && TxtCelular.Text != "" && TxtDirección.Text != "")
            {
                // Agregar una nueva fila al DataGridView
                DgvProveedores.Rows.Add(TxtEmpresa.Text, TxtProductos.Text, TxtNombreContacto.Text, TxtDNI.Text, TxtCelular.Text, TxtCorreo.Text, TxtDirección.Text, TxtSitioWeb.Text);
                LimpiarDatos();
                GuardarDatos();
            }
            else
            {
                MessageBox.Show("Agregar datos");
            }
        }

        private void TxtNombreContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = DgvProveedores.Rows[e.RowIndex];
                TxtEmpresa.Text = selectedRow.Cells[0].Value.ToString();
                TxtProductos.Text = selectedRow.Cells[1].Value.ToString();
                TxtNombreContacto.Text = selectedRow.Cells[2].Value.ToString();
                TxtDNI.Text = selectedRow.Cells[3].Value.ToString();
                TxtCelular.Text = selectedRow.Cells[4].Value.ToString();
                TxtCorreo.Text = selectedRow.Cells[5].Value.ToString();
                TxtDirección.Text = selectedRow.Cells[6].Value.ToString();
                TxtSitioWeb.Text = selectedRow.Cells[7].Value.ToString();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvProveedores.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DgvProveedores.SelectedRows[0];

                selectedRow.Cells[0].Value = TxtEmpresa.Text;
                selectedRow.Cells[1].Value = TxtProductos.Text;
                selectedRow.Cells[2].Value = TxtNombreContacto.Text;
                selectedRow.Cells[3].Value = TxtDNI.Text;
                selectedRow.Cells[4].Value = TxtCelular.Text;
                selectedRow.Cells[5].Value = TxtCorreo.Text;
                selectedRow.Cells[6].Value = TxtDirección.Text;
                selectedRow.Cells[7].Value = TxtSitioWeb.Text;

                LimpiarDatos();
                GuardarDatos();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvProveedores.SelectedRows.Count > 0)
            {
                DgvProveedores.Rows.RemoveAt(DgvProveedores.SelectedRows[0].Index);
                LimpiarDatos();
            }
        }

        public void GuardarDatos()
        {
            string filePath = @"C:\Users\Usuario\Documents\T3 FUNAL INTENTO.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (DataGridViewRow row in DgvProveedores.Rows)
                    {
                        for (int i = 0; i < DgvProveedores.Columns.Count; i++)
                        {
                            writer.Write(row.Cells[i].Value);
                            if (i < DgvProveedores.Columns.Count - 1)
                                writer.Write("\t");
                            else
                                writer.WriteLine();
                        }
                    }

                    MessageBox.Show("Datos guardados correctamente en " + filePath, "Guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarDatos()
        {
            string filePath = @"C:\Users\Usuario\Documents\T3 FUNAL INTENTO.txt";
            try
            {
                if (File.Exists(filePath))  // Verifica si el archivo existe en la ruta especificada.
                {
                    DgvProveedores.Rows.Clear(); // Limpia todas las filas del DataGridView llamado DgvProveedores.

                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string? line; // Cambia de "string" a "string?" para indicar que puede ser null

                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] data = line.Split('\t'); // Divide la línea leída en un array de strings utilizando tabulaciones como separador.
                            DgvProveedores.Rows.Add(data); // Agrega los datos al DataGridView.
                        }
                    }

                    //MessageBox.Show("Datos cargados correctamente desde " + filePath, "Cargar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El archivo no existe: " + filePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtProductos_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCelular_TextChanged(object sender, EventArgs e)
        {


        }

        private void TxtSitioWeb_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblEmpresa_Click(object sender, EventArgs e)
        {

        }
    }
}
