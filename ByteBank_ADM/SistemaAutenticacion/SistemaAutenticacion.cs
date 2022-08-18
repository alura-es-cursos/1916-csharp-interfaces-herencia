using ByteBank_ADM.Autenticables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.SistemaAutenticacion
{
    public class SistemaAutenticacion
    {
        public void loginUsuario(Autenticable autenticable, string clave)
        {
            if (autenticable.autenticarUsuario(clave))
            {
                Console.WriteLine("Usuario válido");
            } else
            {
                Console.WriteLine("Clave incorrecta");
            }
        }

       
    }
}
