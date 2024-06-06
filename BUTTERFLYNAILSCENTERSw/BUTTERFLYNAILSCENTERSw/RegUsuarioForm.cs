//using BUTTERFLYNAILSCENTERSw.DataAccess.Modelos;
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
    public partial class RegUsuarioForm : Form
    {
        public RegUsuarioForm()
        {
            InitializeComponent();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            RegistrarUsuario();
            InsertarDatosEnElGrid();
        }

        //Esta funcion se utiliza para agregar un nuevo usuario.
        void RegistrarUsuario()
        {
            try
            {
                using (var _DBContext = new ButterflyNailsDbContext())
                {

                    if (!ConfirmarCampos())
                    {
                        MessageBox.Show("No pueden haber campos vacios");
                        return;
                    }
                    var nuevoUsuario = new Usuario
                    {
                        Username = nNombreUsuariotb.Text,
                        Password = nPasswordtb.Text,
                        Rol = comboBox1.Text,
                        FechaRegistro = DateTime.Now
                    };

                    bool usuarioExiste = _DBContext.Usuarios.Any(usuario => usuario.Username == nuevoUsuario.Username);

                    if (usuarioExiste)
                    {
                        MessageBox.Show("Este usuario existe. ");
                        return;
                    }

                    _DBContext.Usuarios.Add(nuevoUsuario);
                    _DBContext.SaveChanges();

                    MessageBox.Show("Usuario añadido correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo salio mal! ");
            }

        }
        bool ConfirmarCampos()
            => !String.IsNullOrWhiteSpace(nNombreUsuariotb.Text) &&
               !String.IsNullOrWhiteSpace(nPasswordtb.Text) &&
               !String.IsNullOrWhiteSpace(nPasswordtb.Text) &&
               !String.IsNullOrWhiteSpace(comboBox1.Text);
        void InsertarDatosEnElGrid()
        {
            using (var dbcontext = new ButterflyNailsDbContext())
            {
                var usuariosList = dbcontext.Usuarios.ToList();
                dataGridView1.DataSource = usuariosList;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegUsuarioForm_Load(object sender, EventArgs e)
        {
            InsertarDatosEnElGrid();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

