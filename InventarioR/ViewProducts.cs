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
            if (string.IsNullOrWhiteSpace(txtproducto.Text) ||
         string.IsNullOrWhiteSpace(txtproveedor.Text) ||
        string.IsNullOrWhiteSpace(txtstock.Text) ||
        string.IsNullOrWhiteSpace(txtmarca.Text) ||
        string.IsNullOrWhiteSpace(dateTimeFecha.Text) ||
        string.IsNullOrWhiteSpace(txtcostoU.Text) ||
        string.IsNullOrWhiteSpace(txtdescripcion.Text))
            {
                MessageBox.Show("Rellenar todos los campos");
                return;
            }

            if (!int.TryParse(txtstock.Text, out int stock))
            {
                MessageBox.Show("El campo 'Stock' debe ser un número entero.");
                return;
            }

            if (!decimal.TryParse(txtcostoU.Text, out decimal costoU))
            {
                MessageBox.Show("El campo 'Costo Unitario' debe ser un decimal.");
                return;
            }

            //DateTime fechaActual = DateTime.Now;

            dgvProductos.Rows.Add(txtproducto.Text, txtproveedor.Text, txtmarca.Text, stock, dateTimeFecha.Text, costoU, txtdescripcion.Text);

            limpiarDatos();
        }

        void limpiarDatos()
        {
            txtproducto.Text = "";
            txtproveedor.Text = "";
            txtmarca.Text = "";
            txtstock.Text = "";
            dateTimeFecha.Text = "";
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
    }
}
