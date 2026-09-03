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
    public partial class FrmPila : Form
    {
        public FrmPila()
        {
            InitializeComponent();
        }
        ClsPila objPila = new ClsPila();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsnodo nuevo = new clsnodo();

            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nuevo.Nombre = txtNombre.Text;
            nuevo.Tramite = txtTramite.Text;

            objPila.AgregarPila(nuevo);

            lstPila.Items.Clear();
            objPila.Recorrer(lstPila);


            dgvgrillapila.Rows.Clear();
            objPila.RecorrerDgv(dgvgrillapila);

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();

            txtCodigo.Focus(); // Establecer el foco en el TextBox de código para facilitar la entrada de dato

        }

        private DataGridView GetDgvgrillapila()
        {
            return dgvgrillapila;
        }

        private void FrmPila_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsnodo nuevo = new clsnodo();

            nuevo.Codigo = Convert.ToInt32(txtCode.Text);
            nuevo.Nombre = txtName.Text;
            nuevo.Tramite = txtTram.Text;

            objPila.EliminarPila(nuevo, lstPila);
            objPila.EliminarPila(nuevo, dgvgrillapila);

            txtCode.Clear();
            txtName.Clear();
            txtTram.Clear();

            txtCode.Focus();
        }
    }
}
