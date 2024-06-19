using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplementodeVentas
{
    public partial class RegistroVentas : Form
    {
        double precio = 0;
        public RegistroVentas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("d");
            lblPrecio.Text = (0).ToString("C");
        }

      

        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string producto = cboProductos.Text;

            if (producto.Equals("Coleccion de Pantalones")) precio = 250;
            if (producto.Equals("Coleccion de Polos")) precio = 150;
            if (producto.Equals("Coleccion de Blusas")) precio = 350;
            if (producto.Equals("Coleccion de Casacas")) precio = 450;

            lblPrecio.Text = precio.ToString("C");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //validando
            if (txtNombre.Text == "")
                MessageBox.Show("Debe ingresar un nombre..,!!!");
            else if (cboProductos.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un producto...!!");
            else if (txtCantidad.Text == "")
                MessageBox.Show("Debe ingresar una cantidad..,!!!");
            else if (cboPago.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un tipo de pago...!!");
           
            else
            {
                //capturando datos
                string nombre = txtNombre.Text;
                string producto = cboProductos.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                string tipo = cboPago.Text;

                //procesar calculos 
                double subtotal = cantidad * precio;

                double descuento = 0, recargo = 0;
                if (tipo.Equals("Contado"))
                    descuento = 0.05 * subtotal;
                else
                    recargo = 0.1 * subtotal;
                double precioFinal = subtotal - descuento + recargo;

                //imprimir los resultados
                ListViewItem fila = new ListViewItem(nombre);
                fila.SubItems.Add(producto.ToString());
                fila.SubItems.Add(cantidad.ToString());
                fila.SubItems.Add(precio.ToString());
                fila.SubItems.Add(tipo);
                fila.SubItems.Add(descuento.ToString());
                fila.SubItems.Add(recargo.ToString());
                fila.SubItems.Add(precioFinal.ToString());

                lvVenta.Items.Add(fila);
                btnCancelar_Click(sender, e);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cboProductos.Text = ("Seleccione producto");
            cboPago.Text = ("Seleccione tipo");
            txtCantidad.Clear();
            lblPrecio.Text = (0).ToString("C");
            cboProductos.Focus();
        }

     
        

        }
    }


