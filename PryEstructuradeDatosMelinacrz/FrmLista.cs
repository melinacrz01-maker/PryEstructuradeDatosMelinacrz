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
    public partial class FrmLista : Form
    {
        public FrmLista()
        {
            InitializeComponent();
        }
        ClslistaSimple objLista = new ClslistaSimple();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsnodo nuevo = new clsnodo();

            nuevo.Codigo = Convert.ToInt32(txtCode.Text);
            nuevo.Nombre = txtName.Text;
            nuevo.Tramite = txtTramite.Text;

            objLista.Agregar(nuevo);

            objLista.recorrer(lstLista);
            objLista.recorrer(dgvTable);
            objLista.recorrer(comboBox1);

            txtCode.Clear();
            txtName.Clear();
            txtTramite.Clear();

            txtCode.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objLista.Eliminar(Convert.ToInt32(comboBox1.SelectedItem));

            objLista.recorrer(lstLista);
            objLista.recorrer(dgvTable);
            objLista.recorrer(comboBox1);
        }
    }
}
