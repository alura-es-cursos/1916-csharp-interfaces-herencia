using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Directores
{
    public class Director
    {
        public Director()
        {
            
        }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Dni { get; set; }
        public double Salario { get; set; }
        public string Departamento { get; set; }

        public double obtenerBonificacion()
        {
            return this.Salario * 0.35;

        }
    }
}
