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
    public partial class AggServicioForm : Form
    {
        public AggServicioForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarServicio();
            InsertarDatosEnElGrid();
        }

        bool ConfirmarCampos()
           => !String.IsNullOrWhiteSpace(nombreServicio.Text) &&
              !String.IsNullOrWhiteSpace(precioServicio.Text) &&
              !String.IsNullOrWhiteSpace(descServicio.Text);
        void RegistrarServicio()
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
                    var nuevoServicio = new Servicio
                    {
                        Nombre = nombreServicio.Text,
                        Descripcion = descServicio.Text,
                        Precio = Convert.ToDouble(precioServicio.Text)
                    };
                    _DBContext.Servicios.Add(nuevoServicio);
                    _DBContext.SaveChanges();

                    MessageBox.Show("Servicio añadido correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo salio mal! ");
            }
        }
        void InsertarDatosEnElGrid()
        {
            using (var _DBContext = new ButterflyNailsDbContext())
            {
                var serviciosList = _DBContext.Servicios.ToList();
                dataGridView1.DataSource = serviciosList;
            }
        }
        private void aggServiciobtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
