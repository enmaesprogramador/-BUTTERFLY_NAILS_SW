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
    public partial class RegCitasForm : Form
    {
        public RegCitasForm()
        {
            InitializeComponent();
        }
        void InsertarDatosEnElGrid()
        {
            using (var _DBContext = new ButterflyNailsDbContext())
            {
                var citasList = _DBContext.Citas.ToList();
                dataGridView1.DataSource = citasList;
            }
        }

        private void aggBtn_Click(object sender, EventArgs e)
        {
            RegistrarCita();
            InsertarDatosEnElGrid();
        }
        void RegistrarCita()
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
                    var clienteParaLaCita = _DBContext.Clientes.FirstOrDefault(x => x.Nombre == nombreClienteComboBox.Text);
                    var servicioParaLaCita = _DBContext.Servicios.FirstOrDefault(x => x.Nombre == servicioComboBox.Text);



                    var nuevaCita = new Cita
                    {
                        ClienteId = clienteParaLaCita!.Id,
                        ServicioId = servicioParaLaCita!.Id,
                        Fecha = Convert.ToDateTime(dateTimePicker1.Value.ToString("dd/MM/yyyy")),
                        FechaDeRegistro = DateTime.Now,
                        Status = "Pendiente"
                    };

                    _DBContext.Citas.Add(nuevaCita);
                    _DBContext.SaveChanges();

                    MessageBox.Show("Cita registrada correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo salio mal! ");
            }

        }
        bool ConfirmarCampos()
            => !String.IsNullOrWhiteSpace(nombreClienteComboBox.Text) &&
               !String.IsNullOrWhiteSpace(servicioComboBox.Text);
        void InsertarClientesComboBox()
        {
            using (ButterflyNailsDbContext _DBContext = new())
            {
                var listaClientes = _DBContext.Clientes.Select(x => x.Nombre);
                foreach (var cliente in listaClientes)
                {
                    nombreClienteComboBox.Items.Add(cliente!);
                }
            }
        }
        void InsertarServiciosComboBox()
        {
            using (ButterflyNailsDbContext _DBContext = new())
            {
                var listaServicios = _DBContext.Servicios.Select(x => x.Nombre);
                foreach (var cliente in listaServicios)
                {
                    servicioComboBox.Items.Add(cliente!);
                }
            }
        }

        private void RegCitasForm_Load(object sender, EventArgs e)
        {
            InsertarClientesComboBox();
            InsertarServiciosComboBox();
            InsertarDatosEnElGrid();
        }

        private void cerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
