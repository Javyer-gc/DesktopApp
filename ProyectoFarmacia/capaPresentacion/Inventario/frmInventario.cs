using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion.Inventario
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsProyecto.TABLA_MEDICAMENTO' Puede moverla o quitarla según sea necesario.
            this.tABLA_MEDICAMENTOTableAdapter.Fill(this.dsProyecto.TABLA_MEDICAMENTO);
        }
    }
}
