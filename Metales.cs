using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1._1_SistemaDeMineriaEspacial
{
    enum TipoMetales
    {
        Hierro, Oro, Platino, MetalesMiscelaneos
    }

    class Metales
    {
        private int totalHierro;
        private int totalOro;
        private int totalPlatino;
        private int totalMetalesMiscelaneos;
        private int totalPesoAsteroides;

        private int totalHierroActual;
        private int totalOroActual;
        private int totalPlatinoActual;
        private int totalMetalesMiscelaneosActual;
        private int totalPesoAsteroidesActuales;

        public Metales()
        {
            // Inicializa todas las cantidades en 0.
            totalHierro = 0;
            totalOro = 0;
            totalPlatino = 0;
            totalMetalesMiscelaneos = 0;
            totalPesoAsteroides = 0;

            totalHierroActual = 0;
            totalOroActual = 0;
            totalPlatinoActual = 0;
            totalMetalesMiscelaneosActual = 0;
            totalPesoAsteroidesActuales = 0;
        }

        public void GenerarComposicionMineral()
        {
            Asteroides asteroide = new Asteroides();
            Random random = new Random();

            int tipoAsteroide = asteroide.GenerarTamañoAsteroidesAleatorios();
            int pesoAsteroide = asteroide.DeterminarPesoAsteroide(tipoAsteroide);

            // Cálculo de los porcentajes de distribución de minerales
            int porcentajeHierro = random.Next(30, 51);
            int porcentajeOro = random.Next(10, 26);
            int porcentajePlatino = random.Next(5, 11);

            // Cálculo de las cantidades de minerales según los porcentajes y el peso máximo
            int hierro = (pesoAsteroide * porcentajeHierro) / 100;
            int oro = (pesoAsteroide * porcentajeOro) / 100;
            int platino = (pesoAsteroide * porcentajePlatino) / 100;
            int metalesMiscelaneos = pesoAsteroide - (hierro + oro + platino);

            // Suma los valores al actual
            totalHierroActual = hierro;
            totalOroActual = oro;
            totalPlatinoActual = platino;
            totalMetalesMiscelaneosActual = metalesMiscelaneos;
            totalPesoAsteroidesActuales = pesoAsteroide;

            // Suma los valores al total
            totalHierro += hierro;
            totalOro += oro;
            totalPlatino += platino;
            totalMetalesMiscelaneos += metalesMiscelaneos;
            totalPesoAsteroides += pesoAsteroide;

            Console.WriteLine($"Hierro: {hierro} KG");
            Console.WriteLine($"Oro: {oro} KG");
            Console.WriteLine($"Platino: {platino} KG");
            Console.WriteLine($"Metales Misceláneos: {metalesMiscelaneos} KG");
            Console.WriteLine($"Por un total de {pesoAsteroide} KG de carga.");
        }

        public void MostrarTotales()
        {
            Console.WriteLine($"\n*** Valores Totales ***:\n\nHierro: {totalHierro} KG\nOro: {totalOro} KG\nPlatino: {totalPlatino} KG\nMetales Miscelaneos: {totalMetalesMiscelaneos} KG\nTotal en KG de minerales" +
                $" extraídos: {totalPesoAsteroides}\n");
        }

        public void MostrarActuales()
        {
            Console.WriteLine($"\nTotales actuales:\nHierro: {totalHierroActual} KG\nOro: {totalOroActual} KG\nPlatino: {totalPlatinoActual} KG\nMetales Miscelaneos: {totalMetalesMiscelaneosActual} KG\nTotal en KG de minerales" +
                $" extraídos: {totalPesoAsteroidesActuales}\n");

            // Reinicia los valores actuales a 0.
            totalHierroActual = 0;
            totalOroActual = 0;
            totalPlatinoActual = 0;
            totalMetalesMiscelaneosActual = 0;
            totalPesoAsteroidesActuales = 0;
        }

        public void MostrarMensajeSalida()
        {

            Console.WriteLine($"\n*** Cantidades Totales Extraidas durante esta sesion:  ***\n\nHierro: {totalHierro} KG\nOro: {totalOro} KG\nPlatino: {totalPlatino} KG\nMetales Miscelaneos: {totalMetalesMiscelaneos} KG\nTotal en KG de minerales" +
                $" extraídos: {totalPesoAsteroides} \n");
        }
    }
}
