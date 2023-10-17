using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1._1_SistemaDeMineriaEspacial
{
    enum TamañoAsteroides
    {
        Pequeño, Mediano, Grande, Cataclismico
    }

    enum CantidadAsteroides
    {
        a,b,c,d,e,f,g
    }
    class Asteroides
    {       
        // Genero el tamaño del asteroide
        public int GenerarTamañoAsteroidesAleatorios()
        {
            Random random = new Random();
            int tamañoAsteroides = Enum.GetValues(typeof(TamañoAsteroides)).Length;
            int tamañoAsteroide = random.Next(0, tamañoAsteroides);
            return tamañoAsteroide;
        }

        // Genero la cantidad de Asteroides
        public int GenerarCantidadAsteroidesAleatorios()
        {
            Random random = new Random();
            int cantidad = Enum.GetValues(typeof(CantidadAsteroides)).Length;
            int valorAleatorio = random.Next(0, cantidad);
            return valorAleatorio;
        }

        // Genero el peso del asteroide, segun el tamaño del mismo
        public int DeterminarPesoAsteroide(int tamañoAsteroide)
        {
            int[] pesos = { 1000, 2000, 5000, 10000 };
            if (tamañoAsteroide >= 0 && tamañoAsteroide < pesos.Length)
            {
                return pesos[tamañoAsteroide];
            }
            return pesos[tamañoAsteroide];
        }
    }
}
