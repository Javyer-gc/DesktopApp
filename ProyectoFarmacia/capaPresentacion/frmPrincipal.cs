

namespace capaPresentacion
{
    using System;
    using System.Windows.Forms;
    using capaPresentacion.Inventario;
    using capaPresentacion.Medicamentos;
    using capaSoporte.Cache;

    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {

            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // la opción ver inventario solo será visible para empleados y administradores
            CargaDatosUsuario();
            if (UsuarioCache.idTipoUsuario == 1 || UsuarioCache.idTipoUsuario == 2   )
            {
               
            }
            else
            {
                btInventario.Hide();
            }
        }

        private void CargaDatosUsuario()
        {
            // Para imprimir el tipo de usuario en el formulario principal
            string[] Tipousuario =  { "NONE","Administrador", "Empleado", "Cliente" } ;

            lblNombre.Text = UsuarioCache.Nombre;
            lblAPaterno.Text = UsuarioCache.APaterno;
            lblAMaterno.Text = UsuarioCache.AMaterno;
            lblTipoUsuario.Text = Tipousuario[UsuarioCache.idTipoUsuario];
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Acceso a administracion de empleados (sólo administradores (id = 2) pueden accesar)
        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            if (UsuarioCache.idTipoUsuario == 1) // poner  0 para poder acceder en fase de desarrollo
            {
                Ajustes.frmEmpleados Form = new Ajustes.frmEmpleados();
                Form.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permiso para acceder a esta opción, Inicie como administrador para acceder");
                return;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btInventario_Click(object sender, EventArgs e)
        {
            frmInventario Form = new frmInventario();
            Form.ShowDialog();
        }

        private void btMedicamentos_Click(object sender, EventArgs e)
        {
            frmMedicamentos Form = new frmMedicamentos();
            Form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
