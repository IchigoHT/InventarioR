using System.Diagnostics.Eventing.Reader;

namespace TRABAJOT3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.ToString("d");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string producto = CboProducto.Text;
            if (producto.Equals("Mueble Amarillo")) ;
            if (producto.Equals("Mueble Rosado")) ;
            if (producto.Equals("Mueble Blanco")) ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CboProducto.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un producto!!");
            else if (CboMedio.Text == "") 
            MessageBox.Show("Debe seleccionar un tipo de pago!!");
            else
            {
                string Nombres, Apellidos, Email, Telefono, DNI;
                    string producto = CboProducto.Text;
            string tipo = CboMedio.Text;
                ListViewItem fila = new ListViewItem(producto);
                    
                

            }


        }
    }
}
