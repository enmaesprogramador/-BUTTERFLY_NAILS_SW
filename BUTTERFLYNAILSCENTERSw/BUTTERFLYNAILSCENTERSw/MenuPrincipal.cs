using BUTTERFLYNAILSCENTERSw.DataAccess;
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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        private Form _activeForm;
        private void OpenChildForm(Form childForm)
        {

            if (_activeForm != null)
                _activeForm.Close();

            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegUsuarioForm());

        }
        private void openClientesForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegClienteForm());

        }

        private void servsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AggServicioForm());

        }

        private void regMetodosDePagoBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegMetodoDePagoForm());
        }

        private void citasBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegCitasForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new VentaServicioForm());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            if (UserSession.UserRol is not "Administrador")
            {
                btnNuevoUsuario.Visible = false;
                regMetodosDePagoBtn.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
