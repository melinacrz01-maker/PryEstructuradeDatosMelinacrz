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
    public partial class ListaEnlazada : Form
    {
        public ListaEnlazada()
        {
            InitializeComponent();
        }
        Clslistadoble objLista = new Clslistadoble();

        private void btnAgregarDatos_Click(object sender, EventArgs e)
        {
            clsnodo nuevo = new clsnodo();

            nuevo.Codigo = Convert.ToInt32(txtCode.Text);
            nuevo.Nombre = txtName.Text;
            nuevo.Tramite = txtTramite.Text;

            objLista.Agregar(nuevo);

            objLista.Recorrer(LstDeDatos);
            objLista.Recorrer(dgvTabladedatos);
            objLista.Recorrer(comboBox1);

            txtCode.Clear();
            txtName.Clear();
            txtTramite.Clear();

            txtCode.Focus();
        }

        private void btnEliminarDatos_Click(object sender, EventArgs e)
        {
            objLista.Eliminar(Convert.ToInt32(comboBox1.SelectedItem));

            objLista.Recorrer(LstDeDatos);
            objLista.Recorrer(dgvTabladedatos);
            objLista.Recorrer(comboBox1);
        }
    }
}
