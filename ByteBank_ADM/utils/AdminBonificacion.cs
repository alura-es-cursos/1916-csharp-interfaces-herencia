using ByteBank_ADM.Directores;
using ByteBank_ADM.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.utils
{
    public class AdminBonificacion
    {
        private double totalBonificaciones = 0.0;

        public void Registrar(Empleado empleado)
        {
            this.totalBonificaciones += empleado.obtenerBonificacion();
        }

        public void Registrar(Director director)
        {
            this.totalBonificaciones += director.obtenerBonificacion();
        }

        public double obtenerTotalBonificaciones()
        {
            return this.totalBonificaciones;
        }
    }
}
