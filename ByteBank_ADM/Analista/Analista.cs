using ByteBank_ADM.Autenticables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Analistas
{
    public class Analista:Autenticable
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
