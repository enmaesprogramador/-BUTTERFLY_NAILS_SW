using BUTTERFLYNAILSCENTERSw.DataAccess.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUTTERFLYNAILSCENTERSw
{
    public partial class RegClienteForm : Form
    {
        public RegClienteForm()
        {
            InitializeComponent();
        }

        void RegistrarCliente()
        {
            try
            {
                using (var _DBContext = new ButterflyNailsDbContext())
                {
                    var nuevoUsuario = new Cliente
                    {
                        Nombre = nCliente.Text,
                        NumeroDeTelefono = telCliente.Text,
                        Direccion = dirCliente.Text,
                        FechaDeRegistro = DateTime.Now
                    };

                    _DBContext.Clientes.Add(nuevoUsuario);
                    _DBContext.SaveChanges();

                    MessageBox.Show("Cliente añadido correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo salio mal! ");
            }

        }

        private void regButton_Click(object sender, EventArgs e)
        {
            RegistrarCliente();
            InsertarDatosEnElGrid();
        }
        void InsertarDatosEnElGrid()
        {
            using (var dbcontext = new ButterflyNailsDbContext())
            {
                var clientes = dbcontext.Clientes.ToList();
                dataGridView1.DataSource = clientes;
            }
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegClienteForm_Load(object sender, EventArgs e)
        {
            InsertarDatosEnElGrid();
        }
    }
}
