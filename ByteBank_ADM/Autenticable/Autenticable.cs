using ByteBank_ADM.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Autenticables
{
    public abstract class Autenticable:Empleado
    {
        public Autenticable(string _Dni, double _Salario) : base(_Dni, _Salario)
        {
        }

        public string Clave { get; set; }
        public bool autenticarUsuario(string clave)
        {
            return this.Clave == clave;
        }

    }
}
