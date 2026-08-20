using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEstructuradeDatosMelinacrz
{
    internal class clsnodo
    {
        private int codigo;
        private string nombre;
        private int codigo1;

        public clsnodo siguiente;

        public int Codigo1 { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Codigo { get => codigo1; set => codigo1 = value; }
    }
}
