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

            dgvProductos.Rows.Add(producto, proveedor, stock, marca, costoU, descripcion);

            txtproducto.Text = "";
            txtproveedor.Text = "";
            txtmarca.Text = "";
            txtstock.Text = "";
            txtcostoU.Text = "";
            txtdescripcion.Text = "";

        }

        void limpiarDatos()
        {
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
    }
}
