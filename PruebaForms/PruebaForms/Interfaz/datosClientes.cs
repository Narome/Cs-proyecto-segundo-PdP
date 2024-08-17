using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaForms.Interfaz
{
    public partial class datosClientes : Form
    {
        public datosClientes()
        {
            InitializeComponent();
        }

        private void datosClientes_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(@"C:\Users\nat_1\OneDrive\Documentos\Universidad\PdP\C #\Proyecto_PdP_2024-main\Proyecto_PdP_2024-main\PruebaForms\PruebaForms\Repositorio\\datosClientes.xml");
                dgvClientes.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar archivo XML de Clientes: " + ex.Message);
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
