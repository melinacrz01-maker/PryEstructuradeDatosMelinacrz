using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEstructuradeDatosMelinacrz
{
    internal class ClslistaSimple
    {
        private clsnodo primero;

        public clsnodo Primero
        {
            get { return primero; }
            set { primero = value; }
        }


        public void Agregar(clsnodo nuevo)
        {
            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                if (nuevo.codigo < primero.codigo)
                {
                    nuevo.siguiente = primero;
                    primero = nuevo;
                    return;
                }
                else
                {
                    clsnodo aux = primero;
                    clsnodo anterior = primero;
                    while (aux != null && nuevo.codigo > aux.codigo)
                    {
                        anterior = aux;
                        aux = aux.siguiente;
                    }

                    anterior.siguiente = nuevo;
                    nuevo.siguiente = aux;
                }
            }
        }

        public void Eliminar(Int32 codigo)
        {
            if (primero.codigo == codigo)
            {
                primero = primero.siguiente;
            }
            else
            {
                clsnodo ant = primero;
                clsnodo aux = primero;
                while (aux.codigo != codigo)
                {
                    ant = aux;
                    aux = aux.siguiente;
                }

                ant.siguiente = aux.siguiente;

            }
        }
        public void recorrer(DataGridView grilla)
        {
            clsnodo aux = primero;
            grilla.Rows.Clear();
            while (aux != null)
            {
                grilla.Rows.Add(aux.codigo, aux.nombre, aux.tramite);
                aux = aux.siguiente;
            }

        }
        public void recorrer(ListBox lista)
        {
            clsnodo aux = primero;
            lista.Items.Clear();
            while (aux != null)
            {
                lista.Items.Add(aux.tramite);
                aux = aux.siguiente;
            }
        }

        public void recorrer(ComboBox combo)
        {
            clsnodo aux = primero;
            combo.Items.Clear();
            while (aux != null)
            {
                combo.Items.Add(aux.codigo);
                aux = aux.siguiente;
            }
        }
    }
}
