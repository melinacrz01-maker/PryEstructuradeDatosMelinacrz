using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEstructuradeDatosMelinacrz
{
    internal class clsnodo
    {
        public int codigo;
        public string nombre;
        public string tramite;

        public clsnodo siguiente;
        public clsnodo anterior;
        public clsnodo Siguiente { get => siguiente; set => siguiente = value; }
        public clsnodo Anterior { get => anterior; set => anterior = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tramite { get => tramite; set => tramite = value; }
    }
}
