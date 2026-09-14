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

        public void recorrer(DataGridView dgvcola)
        {
            dgvcola.Rows.Clear();
            clsnodo aux = Primero;
            while (aux != null)
            {
                dgvcola.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.siguiente;
            }
        }

        //En una cola (FIFO) solo se puede sacar el frente: el primero que se agrego
        public clsnodo EliminarCola()
        {
            if (Primero == null)
            {
                return null;
            }

            clsnodo frente = Primero;

            Primero = frente.siguiente;

            if (Primero == null)
            {
                Ultimo = null;
            }
            else
            {
                Primero.anterior = null;
            }

            frente.siguiente = null;

            return frente;
        }

        //Atiende de a uno hasta sacar el nodo con ese codigo.
        //Sigue siendo cola: adentro solo llama a EliminarCola (Dequeue).
        //Devuelve cuantos nodos se atendieron, 0 si el codigo no estaba.
        public int EliminarColaHasta(int codigo)
        {
            //Primero verifico que exista, si no la cola se vaciaria buscandolo
            clsnodo aux = Primero;

            while (aux != null && aux.Codigo != codigo)
            {
                aux = aux.siguiente;
            }

            if (aux == null)
            {
                return 0;
            }

            int cantidad = 0;
            clsnodo frente;

            do
            {
                frente = EliminarCola();
                cantidad++;
            }
            while (frente.Codigo != codigo);

            return cantidad;
        }

        public int EliminarCola(clsnodo nodoAEliminar, ListBox lstcola)
        {
            int cantidad = EliminarColaHasta(nodoAEliminar.Codigo);

            recorrrer(lstcola);

            return cantidad;
        }

        public int EliminarCola(clsnodo nodoAEliminar, DataGridView dgvcola)
        {
            int cantidad = EliminarColaHasta(nodoAEliminar.Codigo);

            recorrer(dgvcola);

            return cantidad;
        }
    }
}
