using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEstructuradeDatosMelinacrz
{
    internal class clscola
    {
        private clsnodo primero;
        private clsnodo ultimo;

        internal clsnodo Primero { get => primero; set => primero = value; }
        internal clsnodo Ultimo { get => ultimo; set => ultimo = value; }

        public void agregar(clsnodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.siguiente = Nuevo;
                Ultimo = Nuevo;
            }

        }
        public void recorrrer(ListBox lstcola)
        {
            lstcola.Items.Clear();

            clsnodo aux = Primero;
            while (aux != null)
            {
                lstcola.Items.Add(aux.Codigo);
                aux = aux.siguiente;
            }
        }
    }
}



           