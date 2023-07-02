using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEGA
{
    public class cCliente
    {
        private string ci_nit;
        private string nombre_cli;
        private string telefono;

        public string Ci_nit { get => ci_nit; set => ci_nit = value; }
        public string Nombre_cli { get => nombre_cli; set => nombre_cli = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
