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
    public partial class frmMenu : Form  
    {
        public frmMenu()
        {
            InitializeComponent ();
        }
        clscola objcola = new clscola();
        clsnodo objnodo = new clsnodo();
        private void frmenu_Load(object sender, EventArgs e)
        {
           

        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola cola = new frmCola(); cola.Show();
        }
    }
}
