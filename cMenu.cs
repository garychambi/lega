using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEGA
{
    public class cMenu
    {
        private int cantidad;
        private float costo;
        private string descripcion;
        private string nombre_prod;
        private float precio_ven;
        private string tipo;

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float Costo { get => costo; set => costo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Nombre_prod { get => nombre_prod; set => nombre_prod = value; }
        public float Precio_ven { get => precio_ven; set => precio_ven = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
