using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEstructuradeDatosMelinacrz
{
    internal class Clslistadoble
    {
        private clsnodo pri;
        private clsnodo ult;

        public clsnodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public clsnodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(clsnodo nuevo)
        {
            if (nuevo == null) return;

            nuevo.Siguiente = null;
            nuevo.Anterior = null;

            if (Primero == null)
            {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else if (nuevo.Codigo < Primero.Codigo)
            {
                nuevo.siguiente = Primero;
                Primero.anterior = nuevo;
                Primero = nuevo;
            }
            else if (nuevo.Codigo >= Ultimo.Codigo)
            {
                Ultimo.Siguiente = nuevo;
                nuevo.Anterior = Ultimo;
                Ultimo = nuevo;
            }
            else
            {
                clsnodo aux = Primero;

                while (aux != null && aux.Codigo <= nuevo.Codigo)
                {
                    aux = aux.Siguiente;
                }

                clsnodo anterior = aux.Anterior;

                anterior.Siguiente = nuevo;
                nuevo.Anterior = anterior;
                nuevo.Siguiente = aux;
                aux.Anterior = nuevo;
            }
        }

        public void Eliminar(int codigo)
        {
            clsnodo aux = Primero;

            while (aux != null && aux.Codigo != codigo)
            {
                aux = aux.Siguiente;
            }

            if (aux == null) return; // No se encontró el código.

            if (aux.Anterior == null)
            {
                Primero = aux.Siguiente;
            }
            else
            {
                aux.Anterior.Siguiente = aux.Siguiente;
            }

            if (aux.Siguiente == null)
            {
                Ultimo = aux.Anterior;
            }
            else
            {
                aux.Siguiente.Anterior = aux.Anterior;
            }
        }

        public void Recorrer(DataGridView grilla)
        {
            grilla.Rows.Clear();

            clsnodo aux = Primero;

            while (aux != null)
            {
                grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void RecorrerDes(DataGridView grilla)
        {
            grilla.Rows.Clear();

            clsnodo aux = Ultimo;

            while (aux != null)
            {
                grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }
        }

        public void Recorrer(ListBox lista)
        {
            lista.Items.Clear();

            clsnodo aux = Primero;

            while (aux != null)
            {
                lista.Items.Add(aux.Codigo.ToString() + " | " + aux.Nombre + ", " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox combo)
        {
            combo.Items.Clear();

            clsnodo aux = Primero;

            while (aux != null)
            {
                combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
    }
}        