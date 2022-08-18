using ByteBank_ADM.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Analista
{
    public class Analista:Empleado
    {
        public Analista(string _Dni) : base(_Dni, 30000)
        {
            Console.WriteLine("Constructor Analista");
        }

        public override double obtenerBonificacion()
        {
            return this.Salario * 0.20;
        }
    }
}
