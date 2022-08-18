using ByteBank_ADM.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Directores
{
    public class Director:Empleado
    {
        public Director()
        {
            
        }
        
        public string Departamento { get; set; }

        public override double obtenerBonificacion()
        {
            return this.Salario * 0.35 + base.obtenerBonificacion();

        }
    }
}
