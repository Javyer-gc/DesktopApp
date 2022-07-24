
namespace capaPresentacion.Ajustes
{
    using System;
    using System.Windows.Forms;
    using capaDominio;

    public partial class frmEmpleados : Form
    {
        string PageAction;
        capaDominio.UsuarioModel usuarioModel = new UsuarioModel();

        public frmEmpleados()
        {
            InitializeComponent();
           
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsProyecto.DATATABLE_USUARIO' table. You can move, or remove it, as needed.
            this.DATATABLE_USUARIOTableAdapter.Fill(this.dsProyecto.DATATABLE_USUARIO);

            EstadoEditable(false);

        }

        private void EstadoEditable(bool v)
        {
            toolStripAgregar.Enabled = !v;
            toolStripModificar.Enabled = !v;
            toolStripBorrar.Enabled = !v;
            toolStripCancelar.Enabled = v;
            toolStripGuardar.Enabled = v;
            toolStripRegresar.Enabled = !v;

            dgUsuarios.Enabled = !v;
            gbBusquedas.Enabled = !v;
            gbUsuarios.Enabled = v;
        }

        private void txtBNombre_TextChanged(object sender, EventArgs e)
        {
           this.DATATABLE_USUARIOTableAdapter.FillByNOMBRE_U(this.dsProyecto.DATATABLE_USUARIO, "%" + txtBNombre.Text + "%");
           
        }

        private void txtBAPaterno_TextChanged(object sender, EventArgs e)
        {
           this.DATATABLE_USUARIOTableAdapter.FillByAPELLIDO_P_U(this.dsProyecto.DATATABLE_USUARIO, "%" + txtBAPaterno.Text + "%"); ;
        }

        private void txtBAMaterno_TextChanged(object sender, EventArgs e)
        {
           this.DATATABLE_USUARIOTableAdapter.FillByAPELLIDO_M_U(this.dsProyecto.DATATABLE_USUARIO, "%" + txtBAMaterno.Text + "%");
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtAPaterno.Text = string.Empty;
            txtAMaterno.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtVPassword.Text = string.Empty;
        }

        private void toolStripAgregar_Click(object sender, EventArgs e)
        {
            PageAction = "ADD";
            LimpiarCampos();
            EstadoEditable(true);
            txtNombre.Focus();
        }

        private void toolStripModificar_Click(object sender, EventArgs e)
        {
            PageAction = "EDIT";
            CargarDatos();
            EstadoEditable(true);
            txtNombre.Focus();
        }

        private void toolStripCancelar_Click(object sender, EventArgs e)
        {
            EstadoEditable(false);
        }
     
        private void toolStripRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CargarDatos()
        {
            if (dgUsuarios.CurrentCell == null)
            {
                MessageBox.Show(" No hay usuarios en el sistema");
                EstadoEditable(false);
                return;
            }
            txtNombre.Text = dgUsuarios[4, dgUsuarios.CurrentRow.Index].Value.ToString(); 
            txtAPaterno.Text = dgUsuarios[5, dgUsuarios.CurrentRow.Index].Value.ToString();
            txtAMaterno.Text = dgUsuarios[6, dgUsuarios.CurrentRow.Index].Value.ToString();
            txtUsuario.Text = dgUsuarios[2, dgUsuarios.CurrentRow.Index].Value.ToString();
            txtPassword.Text = dgUsuarios[3, dgUsuarios.CurrentRow.Index].Value.ToString();
            txtVPassword.Text = dgUsuarios[3, dgUsuarios.CurrentRow.Index].Value.ToString();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("El nombre está vacío");
                txtNombre.Focus();
                return;
            }

            if (txtAPaterno.Text == string.Empty)
            {
                MessageBox.Show("El Apellido Paterno está vacío");
                txtAPaterno.Focus();
                return;
            }       

            if (txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("El usuario está vacío");
                txtUsuario.Focus();
                return;
            }

            if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("La contraseña está vacía");
                txtPassword.Focus();
                return;
            }


            if (txtPassword.Text != txtVPassword.Text)
            {
                MessageBox.Show("La contraseña no coincide");
                txtPassword.Text = string.Empty;
                txtVPassword.Text = string.Empty;
                txtPassword.Focus();
                return;
            }

            bool alta = usuarioModel.verificaUsuario(txtNombre.Text, txtAPaterno.Text, txtAMaterno.Text);

            if (alta == true && PageAction != "EDIT")
            {
                MessageBox.Show("Existente usuario");
                LimpiarCampos();
                EstadoEditable(false);
                return;
            }

            if (PageAction == "ADD")
            {
                // Pasar cadena de texto combo box Puesto a int
                int Tipousuario = 0;

                if (cmbPuesto.Text == "Empleado")
                {
                    Tipousuario = 2;
                }
                else
                {
                    Tipousuario = 1;
                }
              

                usuarioModel.insertarUsuario( txtNombre.Text.ToUpper(), txtAPaterno.Text.ToUpper(), txtAMaterno.Text.ToUpper(), txtUsuario.Text, txtPassword.Text, Tipousuario);
                this.DATATABLE_USUARIOTableAdapter.Fill(this.dsProyecto.DATATABLE_USUARIO);
                EstadoEditable(false);
                return;
            }

            if (PageAction == "EDIT")
            {
                // Pasar cadena de texto combo box Puesto a int
                int Tipousuario = 0;

                if (cmbPuesto.Text == "Empleado")
                {
                    Tipousuario = 2;
                }
                else
                {
                    Tipousuario = 1;
                }

                int ID;
                ID = Convert.ToInt32(dgUsuarios[0, dgUsuarios.CurrentRow.Index].Value.ToString());
                usuarioModel.editarUsuario(ID, Tipousuario, txtNombre.Text.ToUpper(), txtAPaterno.Text.ToUpper(), txtAMaterno.Text.ToUpper(), txtUsuario.Text, txtPassword.Text);
                this.DATATABLE_USUARIOTableAdapter.Fill(this.dsProyecto.DATATABLE_USUARIO);
                EstadoEditable(false);
                return;
            }
        }

        private void tsEmpleados_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gbBusquedas_Enter(object sender, EventArgs e)
        {

        }

        private void dgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtVPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripBorrar_Click(object sender, EventArgs e)
        {
            //**

            int ID;
            ID = Convert.ToInt32(dgUsuarios[0, dgUsuarios.CurrentRow.Index].Value.ToString());
            usuarioModel.borrarUsuario(ID);
            this.DATATABLE_USUARIOTableAdapter.Fill(this.dsProyecto.DATATABLE_USUARIO);
            EstadoEditable(false);
            return;
        }

        private void txtAPaterno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
