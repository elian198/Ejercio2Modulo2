 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase2Modulo2
{
    internal class Clientes
    {
        public int CodCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Vip { get; set; }


        public Clientes(String nombre, String apellido,int codCliente, bool vip)
        {
            CodCliente = codCliente;
            Nombre = nombre;
            Apellido = apellido;
            Vip = vip;
        }

        public Clientes() { }

        public override string ToString()
        {
          return "Cliente { Nombre: " + Nombre + ", Apellido: " + Apellido + ", Vip: " + Vip + "}" ;
        }

        public string verTipoCliente(bool vip)
        {
            if (vip) return " [PREMIUM]";
            else return " [NORMAL]";
        }
    }
}
