using ComplementodeVentas;
using Inventario;
using Proveedores_Oficial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRABAJOT3;

namespace InventarioR
{
    public partial class MenuR : Form
    {
        public MenuR()
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

        private void btnproveedores_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.Show();
            //this.Hide();

        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            ViewProducts products = new ViewProducts();
            products.Show();
        }

        private void btnRcompra_Click(object sender, EventArgs e)
        {
            RealizarCompra Rcompra = new RealizarCompra();
            Rcompra.Show();
        }

        private void btnRventas_Click(object sender, EventArgs e)
        {
            RegistroVentas Rventas = new RegistroVentas();
            Rventas.Show();
        }
    }
}
