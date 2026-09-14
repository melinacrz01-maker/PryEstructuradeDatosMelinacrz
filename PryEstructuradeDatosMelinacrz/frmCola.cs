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
        clscola objcola = new clscola();

        public frmCola()
        {
            InitializeComponent();
        }
       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsnodo objnodo = new clsnodo();
            objnodo.Codigo = Convert.ToInt32(txtCode.Text);    
            objnodo.Nombre = txtNombre.Text;
            objnodo.Tramite = txtTramite.Text;

            objcola.agregar(objnodo);
            objcola.recorrrer(lstListado);
            objcola.recorrer(dgvTabla);

            MessageBox.Show("agregado correctamente");

            txtCode.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsnodo objnodo = new clsnodo();
            objnodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objnodo.Nombre = txtname.Text;
            objnodo.Tramite = txtramit.Text;

            objcola.EliminarCola(objnodo, lstListado);
            objcola.EliminarCola(objnodo, dgvTabla);
        }

        private void grbdatos_Enter(object sender, EventArgs e)
        {

        }

        private void frmCola_Load(object sender, EventArgs e)
        {

        }
    }
}
