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
    public partial class VentaServicioForm : Form
    {
        public VentaServicioForm()
        {
            InitializeComponent();
        }
        void InsertarClientesComboBox()
        {
            using (ButterflyNailsDbContext _DBContext = new())
            {
                var listaClientes = _DBContext.Clientes.Select(x => x.Nombre);
                foreach (var cliente in listaClientes)
                {
                    clientesComboBox.Items.Add(cliente!);
                }
            }
        }
        void InsertarServiciosComboBox()
        {
            using (ButterflyNailsDbContext _DBContext = new())
            {
                var listaServicios = _DBContext.Servicios.Select(x => x.Nombre);
                foreach (var servicio in listaServicios)
                {
                    serviciosComboBox.Items.Add(servicio!);
                }
            }
        }
        void InsertarDePagoComboBox()
        {
            using (ButterflyNailsDbContext _DBContext = new())
            {
                var listaMetodosPago = _DBContext.Metodosdepagos.Select(x => x.Nombre);
                foreach (var metodo in listaMetodosPago)
                {
                    metodosPagoComboBox.Items.Add(metodo!);
                }
            }
        }
        void InsertarCitasCombox()
        {
            using (ButterflyNailsDbContext _DBContext = new())
            {
                var listaCitas = _DBContext.Citas.Select(x => x.Id);
                foreach (var citas in listaCitas)
                {
                    citasComboBox.Items.Add(citas!);
                }
            }
        }
        void RegistrarServicio()
        {
            try
            {

                using (var _DBContext = new ButterflyNailsDbContext())
                {
                    var citaParaServicio = _DBContext.Citas.FirstOrDefault(x => x.Id == Convert.ToInt32(citasComboBox.Text));
                    var clienteParaLaVenta = _DBContext.Clientes.FirstOrDefault(x => x.Nombre == clientesComboBox.Text);
                    var servicioParaLaVenta = _DBContext.Servicios.FirstOrDefault(x => x.Nombre == serviciosComboBox.Text);
                    var metodoPagoParaServicio = _DBContext.Metodosdepagos.FirstOrDefault(x => x.Nombre == metodosPagoComboBox.Text);

                    var nuevaVenta = new Ventaservicio
                    {
                        ClienteId = clienteParaLaVenta!.Id,
                        ServicioId = servicioParaLaVenta!.Id,
                        MetodoPagoId = metodoPagoParaServicio!.Id,
                        CitaId = citaParaServicio!.Id
                    };
                    citaParaServicio.Status = "Cerrada";
                    _DBContext.Ventaservicios.Add(nuevaVenta);
                    _DBContext.Citas.Update(citaParaServicio);
                    _DBContext.SaveChanges();

                    MessageBox.Show("Servicio registrado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo salio mal! ");
            }

        }
        void InsertarDatosEnElGrid()
        {
            using (var dbcontext = new ButterflyNailsDbContext())
            {
                var serviciosVendidos = dbcontext.Ventaservicios.ToList();
                dataGridView1.DataSource = serviciosVendidos;
            }
        }
        void InsertarCitasEnElGrid()
        {
            using (var _DBContext = new ButterflyNailsDbContext())
            {
                var citasList = _DBContext.Citas.ToList();
                dataGridView2.DataSource = citasList;
            }
        }
        private void VentaServicioForm_Load(object sender, EventArgs e)
        {
            InsertarClientesComboBox();
            InsertarServiciosComboBox();
            InsertarDePagoComboBox();
            InsertarCitasCombox();
            InsertarDatosEnElGrid();
            InsertarCitasEnElGrid();
            label1.Text = "Servicio:";
            label2.Text = "Nombre: ";
            label3.Text = "Metodo De Pago: ";
            label4.Text = "Id De Cita:";
            label5.Text = "Servicios Vendidos: ";
            label6.Text = "Citas: ";
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            RegistrarServicio();
            InsertarDatosEnElGrid();
            InsertarCitasEnElGrid();
        }

        private void citasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
