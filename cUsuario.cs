using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEGA
{
    public class cUsuario
    {
        private string ci;
        private string cuenta;
        private DateTime fecha_nac;
        private string nombre_com;
        private string password;
        private string rol;
        private float salario;

        public string Ci { get => ci; set => ci = value; }
        public string Cuenta { get => cuenta; set => cuenta = value; }
        public DateTime Fecha_nac { get => fecha_nac; set => fecha_nac = value; }
        public string Nombre_com { get => nombre_com; set => nombre_com = value; }
        public string Password { get => password; set => password = value; }
        public string Rol { get => rol; set => rol = value; }
        public float Salario { get => salario; set => salario = value; }
    }
}
