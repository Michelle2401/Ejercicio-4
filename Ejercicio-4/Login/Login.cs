using Datos;
using VistaLog;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (CodigoUsuarioTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CodigoUsuarioTextBox, "Por favor ingrese un codigo de usuario");
                CodigoUsuarioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (ClaveText.Text == string.Empty)
            {

                errorProvider1.SetError(ClaveText, "Por favor ingrese una clave");
                ClaveText.Focus();
                return;
            }
            errorProvider1.Clear();


            UsuarioDatos userDatos = new UsuarioDatos();
            bool valido = await userDatos.loginAsync(CodigoUsuarioTextBox.Text, ClaveText.Text);

            if (valido)
            {
                Menu formulario = new Menu();
                Hide();
                formulario.Show();


            }
            else
            {
                MessageBox.Show("Datos de usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancelarbutton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}