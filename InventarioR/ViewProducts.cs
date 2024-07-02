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
            string producto, proveedor, stock, marca, costoU, descripcion;

            producto = txtproducto.Text;
            proveedor = txtproveedor.Text;
            stock = txtstock.Text;
            marca = txtmarca.Text;
            costoU = txtcostoU.Text;
            descripcion = txtdescripcion.Text;

            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(producto) ||
                string.IsNullOrWhiteSpace(proveedor) ||
                string.IsNullOrWhiteSpace(stock) ||
                string.IsNullOrWhiteSpace(marca) ||
                string.IsNullOrWhiteSpace(costoU) ||
                string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("Todos los campos deben estar llenos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que stock y costoU sean números
            if (!int.TryParse(stock, out _) || !decimal.TryParse(costoU, out _))
            {
                MessageBox.Show("Los campos 'Stock' y 'Costo Unitario' deben ser números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            dgvProductos.Rows.Add(producto, proveedor, stock, marca, costoU, descripcion);

            txtproducto.Text = "";
            txtproveedor.Text = "";
            txtmarca.Text = "";
            txtstock.Text = "";
            txtcostoU.Text = "";
            txtdescripcion.Text = "";

        }


        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewProducts_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("d");
        }

        private void dgvProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvProductos.Rows.Count)
            {
                DataGridViewRow filaseleccionada = dgvProductos.Rows[e.RowIndex];

                txtproducto.Text = filaseleccionada.Cells[0].Value?.ToString();
                txtproveedor.Text = filaseleccionada.Cells[1].Value?.ToString();
                txtmarca.Text = filaseleccionada.Cells[2].Value?.ToString();
                txtstock.Text = filaseleccionada.Cells[3].Value?.ToString();
                txtcostoU.Text = filaseleccionada.Cells[4].Value?.ToString();
                txtdescripcion.Text = filaseleccionada.Cells[5].Value?.ToString();

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {

                string producto = txtproducto.Text;
                string proveedor = txtproveedor.Text;
                string stock = txtstock.Text;
                string marca = txtmarca.Text;
                string costoU = txtcostoU.Text;
                string descripcion = txtdescripcion.Text;

                // Validar campos vacíos
                if (string.IsNullOrWhiteSpace(producto) ||
                    string.IsNullOrWhiteSpace(proveedor) ||
                    string.IsNullOrWhiteSpace(stock) ||
                    string.IsNullOrWhiteSpace(marca) ||
                    string.IsNullOrWhiteSpace(costoU) ||
                    string.IsNullOrWhiteSpace(descripcion))
                {
                    MessageBox.Show("Todos los campos deben estar llenos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar que stock y costoU sean números
                if (!int.TryParse(stock, out _) || !decimal.TryParse(costoU, out _))
                {
                    MessageBox.Show("Los campos 'Stock' y 'Costo Unitario' deben ser números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataGridViewRow filaseleccionada = dgvProductos.SelectedRows[0];

                filaseleccionada.Cells[0].Value = txtproducto.Text;
                filaseleccionada.Cells[1].Value = txtproveedor.Text;
                filaseleccionada.Cells[2].Value = txtmarca.Text;
                filaseleccionada.Cells[3].Value = txtstock.Text;
                filaseleccionada.Cells[4].Value = txtcostoU.Text;
                filaseleccionada.Cells[5].Value = txtdescripcion.Text;

                dgvProductos.Refresh();
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvProductos.SelectedRows[0];
                dgvProductos.Rows.Remove(fila);
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila antes de eliminar");
            }

            txtproducto.Text = "";
            txtproveedor.Text = "";
            txtmarca.Text = "";
            txtstock.Text = "";
            txtcostoU.Text = "";
            txtdescripcion.Text = "";
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
        }
    }
}
