using ByteBank_ADM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Empleados
{
    public class Empleado
    {
        public Empleado()
        {
            
        }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Dni { get; set; }
        public double Salario { get; set; }

       //private int Tipo { get; set; }

        public virtual double obtenerBonificacion()
        {
            return this.Salario * 0.1;
        }
       
    }
}
