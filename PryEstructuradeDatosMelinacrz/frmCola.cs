using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEstructuradeDatosMelinacrz
{
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }
       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        clscola objcola = new clscola();
        clsnodo objnodo = new clsnodo();
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            objnodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objnodo.Nombre = txtname.Text;
            





            txtCodigo.Text = "";
            txtname.Clear();
            txtramit.Clear();


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void grbdatos_Enter(object sender, EventArgs e)
        {

        }
    }
}
