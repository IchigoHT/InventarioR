using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class ViewProducts : Form
    {
        public ViewProducts()
        {
            InitializeComponent();
            dgvProductos.AllowUserToAddRows = false;
        }
        private void ViewProducts_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("d");
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(txtproducto.Text) ||
                string.IsNullOrWhiteSpace(txtproveedor.Text) ||
                string.IsNullOrWhiteSpace(txtmarca.Text) ||
                string.IsNullOrWhiteSpace(txtstock.Text) ||
                string.IsNullOrWhiteSpace(txtcostoU.Text) ||
                string.IsNullOrWhiteSpace(txtdescripcion.Text))
            {
                MessageBox.Show("Rellenar todos los campos");
                return;
            }

            // Verificar que el campo 'Stock' sea un número entero
            if (!int.TryParse(txtstock.Text, out int stock))
            {
                MessageBox.Show("El campo 'Stock' debe ser un número entero.");
                return;
            }

            // Verificar que el campo 'Costo Unitario' sea un número decimal
            if (!decimal.TryParse(txtcostoU.Text, out decimal costoU))
            {
                MessageBox.Show("El campo 'Costo Unitario' debe ser un número decimal.");
                return;
            }

            // Agregar los valores al DataGridView
            dgvProductos.Rows.Add(txtproducto.Text, txtproveedor.Text, txtmarca.Text, stock, costoU, txtdescripcion.Text);

            // Limpiar los campos después de agregar
            limpiarDatos();
        }

        private void limpiarDatos()
        {
            txtproducto.Clear();
            txtproveedor.Clear();
            txtmarca.Clear();
            txtstock.Clear();
            txtcostoU.Clear();
            txtdescripcion.Clear();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvProductos.Rows[e.RowIndex];
                txtproducto.Text = selectedRow.Cells[0].Value.ToString();
                txtproveedor.Text = selectedRow.Cells[1].Value.ToString();
                txtmarca.Text = selectedRow.Cells[2].Value.ToString();
                txtstock.Text = selectedRow.Cells[3].Value.ToString();
                txtcostoU.Text = selectedRow.Cells[4].Value.ToString();
                txtdescripcion.Text = selectedRow.Cells[5].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProductos.SelectedRows[0];

                selectedRow.Cells[0].Value = txtproducto.Text;
                selectedRow.Cells[1].Value = txtproveedor.Text;
                selectedRow.Cells[2].Value = txtmarca.Text;
                selectedRow.Cells[3].Value = txtstock.Text;
                selectedRow.Cells[4].Value = txtcostoU.Text;
                selectedRow.Cells[5].Value = txtdescripcion.Text;

                limpiarDatos();
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                dgvProductos.Rows.RemoveAt(dgvProductos.SelectedRows[0].Index);
                limpiarDatos();
            }
        }
    }
}
