

namespace capaPresentacion
{
    using System;
    using System.Windows.Forms;
    using capaDominio;


    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            // Para acceder sin usuario ni contraseña ( uso solo en fase de desarrollo)
          //  frmPrincipal form = new frmPrincipal();
         //   form.ShowDialog();

            if (txtUsuario.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                if (txtUsuario.Text == string.Empty)
                {
                    MessageBox.Show("NO HAS INTRODUCIDO EL NOMBRE", "Protecto Farmacia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Focus();
                    return;
                }
                if (txtPassword.Text == string.Empty)
                {
                    MessageBox.Show("NO HAS INTRODUCIDO LA CONTRASEÑA", "Protecto Farmacia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Focus();
                    return;
                }

                UsuarioModel usuarioModel = new UsuarioModel();
                var loginValido = usuarioModel.LoginUser(txtUsuario.Text, txtPassword.Text);
                if (loginValido == true)
                {
                    frmPrincipal form = new frmPrincipal();
                    form.ShowDialog();
                    txtUsuario.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    txtUsuario.Focus();
                }
                else
                {
                    MessageBox.Show("LOS DATOS SON INCORRECTOS", "Proyecto Farmacia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Focus();
                    txtUsuario.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    return;
                }
            }
            else
            {
                MessageBox.Show("FALTO LLENAR LOS CAMPOS", "Protecto Farmacia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
