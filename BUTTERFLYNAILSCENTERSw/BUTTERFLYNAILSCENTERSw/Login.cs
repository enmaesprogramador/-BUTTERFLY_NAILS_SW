using BUTTERFLYNAILSCENTERSw.DataAccess;
using BUTTERFLYNAILSCENTERSw.DataAccess.Modelos;

namespace BUTTERFLYNAILSCENTERSw
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        void FuncionLogin()
        {
            int retries = 0;
            if (!ConfirmarCampos())
            {
                MessageBox.Show("No pueden haber campos vacios. ");
                return;
            }
            string? username = unTextBox.Text;
            string? contrasena = passTextBox.Text;
            using (var _DBContext = new ButterflyNailsDbContext())
            {
                var credenciales = _DBContext.Usuarios.SingleOrDefault(x => x.Username == username);
                if (credenciales != null && credenciales.Password == contrasena)
                {
                    UserSession.UserRol = _DBContext.Usuarios.Where(un => un.Username == username).Select(r => r.Rol).FirstOrDefault();
                    UserSession.UserName = unTextBox.Text;
                    MenuPrincipal menuPrincipal = new MenuPrincipal();
                    MessageBox.Show("Se inicio sesion exitosamente.");
                    menuPrincipal.Show();
                }
                else if (credenciales != null && credenciales.Password != contrasena)
                {

                    MessageBox.Show("La contraseña es incorrecta.");

                    if (retries < 3)
                    {
                        retries++;
                        if (retries == 3)
                        {
                            MessageBox.Show("Se ha alcanzado el limite de intentos. ");
                            logButton.Enabled = false;
                            unTextBox.Enabled = false;
                            passTextBox.Enabled = false;
                        }
                    }
                }

            }
        }
        bool ConfirmarCampos()
           => !String.IsNullOrWhiteSpace(unTextBox.Text) &&
              !String.IsNullOrWhiteSpace(passTextBox.Text);
        private void logButton_Click(object sender, EventArgs e)
        {
            FuncionLogin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
