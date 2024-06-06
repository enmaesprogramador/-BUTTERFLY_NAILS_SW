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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                    if (!ConfirmarCampos())
                    {
                        MessageBox.Show("No pueden haber campos vacios. ");
                        return;

                    }
                    var nuevoCliente = new Cliente
                    {
                        Nombre = nCliente.Text,
                        NumeroDeTelefono = telCliente.Text,
                        Direccion = dirCliente.Text,
                        FechaDeRegistro = DateTime.Now
                    };

                    bool clienteExiste = _DBContext.Clientes.Any(cliente => cliente.Nombre == nuevoCliente.Nombre);

                    if (clienteExiste)
                    {
                        MessageBox.Show("Este cliente existe. ");
                        return;
                    }

                    _DBContext.Clientes.Add(nuevoCliente);
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
        bool ConfirmarCampos()
            => !String.IsNullOrWhiteSpace(telCliente.Text) &&
               !String.IsNullOrWhiteSpace(nCliente.Text) && 
               !String.IsNullOrWhiteSpace(dirCliente.Text);

        private void RegClienteForm_Load(object sender, EventArgs e)
        {
            InsertarDatosEnElGrid();
        }
    }
}
