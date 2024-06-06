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
    public partial class RegMetodoDePagoForm : Form
    {
        public RegMetodoDePagoForm()
        {
            InitializeComponent();
        }

        private void aggBtn_Click(object sender, EventArgs e)
        {
            MetodoPago();
            InsertarDatosEnElGrid();
        }
        void MetodoPago()
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
                    var nuevoMetodoDePago = new Metodosdepago
                    {
                        Nombre = comboBox1.Text,
                        FechaDeRegistro = DateTime.Now,
                    };

                    bool metodoExiste = _DBContext.Metodosdepagos.Any(metodo => metodo.Nombre == nuevoMetodoDePago.Nombre);

                    if (metodoExiste)
                    {
                        MessageBox.Show("Este metodo de pago existe. ");
                        return;
                    }

                    _DBContext.Metodosdepagos.Add(nuevoMetodoDePago);
                    _DBContext.SaveChanges();

                    MessageBox.Show("Metodo añadido correctamente.");
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
                var metodosPagoList = dbcontext.Metodosdepagos.ToList();
                dataGridView1.DataSource = metodosPagoList;
            }
        }
        private void cerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool ConfirmarCampos()
            => !String.IsNullOrWhiteSpace(comboBox1.Text);

        private void RegMetodoDePagoForm_Load(object sender, EventArgs e)
        {
            InsertarDatosEnElGrid();
        }
    }
}
