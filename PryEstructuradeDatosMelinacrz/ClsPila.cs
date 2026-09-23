using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEstructuradeDatosMelinacrz
{
    internal class ClsPila
    {
        private clsnodo primero;
        private clsnodo ultimo;

        internal clsnodo Primero { get => primero; set => primero = value; }
        internal clsnodo Ultimo { get => ultimo; set => ultimo = value; }

        public void AgregarPila(clsnodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                //Señalo al nuevo nodo
                Nuevo.siguiente = Primero;
                //Asigno el nuevo nodo a Primero
                Primero = Nuevo;
            }

        }

        public void AgregarPilaAnterior(clsnodo Nuevo)
        {

            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                Primero.anterior = Nuevo;
                Nuevo.siguiente = Primero;
                Primero = Nuevo;
            }
        }

        public void Recorrer(ListBox lbListado)
        {
            clsnodo aux = Primero;

            lbListado.Items.Clear();

            while (aux != null)
            {
                lbListado.Items.Add(aux.Codigo.ToString() + " | " + aux.Nombre + ", " + aux.Tramite);
                aux = aux.siguiente;
            }
        }

        public void RecorrerDgv(DataGridView dgvListado)
        {
            clsnodo aux = Primero;

            dgvListado.Rows.Clear();

            while (aux != null)
            {
                dgvListado.Rows.Add(
                    aux.Codigo.ToString(),
                    aux.Nombre,
                    aux.Tramite
                    );

                aux = aux.siguiente;
            }
        }

        //En una pila (LIFO) solo se puede sacar el tope: el ultimo que se agrego
        public clsnodo EliminarPila()
        {
            if (Primero == null)
            {
                return null;
            }

            clsnodo tope = Primero;

            Primero = tope.siguiente;

            if (Primero == null)
            {
                Ultimo = null;
            }
            else
            {
                Primero.anterior = null;
            }

            tope.siguiente = null;

            return tope;
        }
    }
}
