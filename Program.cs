using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1._1_SistemaDeMineriaEspacial
{
    class InicioPrograma
    {
        static void Main(string[] args)
        {
            Sistema sistema = new Sistema(); // Referncia a la clase Sistema
            Asteroides asteroide = new Asteroides(); // Referencia a la clase Asteroides

            sistema.MensajeBienvenida();

            sistema.Sistema_y_Asteroide_Aleatorio();
        }
    }
}
