using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1._1_SistemaDeMineriaEspacial
{
    class Sistema
    {
        int cantidadAsteroidesTotales = 0;
        int cantidadSistemasVisitados = 0;
        int totalHierro = 0;
        int totalOro = 0;
        int totalPlatino = 0;
        int totalMetalesMiscelaneos = 0;
        int cantidad = 0;
        int tipo = 0;

        public void MensajeBienvenida()
        {
            Console.WriteLine("Programa CEC - Encendido.\nBienvenido al sistema de minería espacial automatizado.");
            Console.WriteLine("Qué operación desea realizar? Ingrese el número deseado:");
            Console.WriteLine("1 - Ingresar a un sistema.");
            Console.WriteLine("2 - Apagar y salir del programa.");
        }

        // Método para crear un nombre de sistema aleatorio
        public string CrearSistemaAleatorio()
        {
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            char[] sistema = new char[5];

            for (int i = 0; i < sistema.Length; i++)
            {
                sistema[i] = caracteres[random.Next(caracteres.Length)];
            }

            return $"[{new string(sistema)}XB]";
        }

        public string NombreDeAsteroideAleatorio()
        {
            const string caracteres2 = "abcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            char[] sistema2 = new char[3];
            
            for (int i = 0; i < sistema2.Length; i++)
            {
                sistema2[i] = caracteres2[random.Next(caracteres2.Length)] ;
            }

            return $"Nombre de Asteroide Actual: {new string(sistema2)}";
        }

        public void Sistema_y_Asteroide_Aleatorio()
        {
            Asteroides asteroide = new Asteroides();
            Metales metales = new Metales();

            bool continuar = false;
            while (!continuar)
            {
                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    if (opcion == 2)
                    {
                        continuar = true;
                    }
                    else if (opcion == 1)
                    {
                        string sistemaAleatorio = CrearSistemaAleatorio();
                        int cantidadAsteroides = asteroide.GenerarCantidadAsteroidesAleatorios();
                        cantidadAsteroidesTotales += cantidadAsteroides;
                        cantidadSistemasVisitados++;

                        if (cantidadAsteroides == 0)
                        {
                            Console.WriteLine("Lo lamento, el sistema encontrado no posee asteroides.");
                            Console.WriteLine("Desea continuar al siguiente sistema o salir del programa?\n1 _ Continuar al siguiente Sistema.\n2 _ Terminar programa.\n");
                            continue;
                        }
                                               
                        
                        Console.WriteLine($"\nSistema aleatorio generado - Entrando en el sistema {sistemaAleatorio}");
                        Console.WriteLine($"El sistema contiene {cantidadAsteroides} asteroides totales.\n");

                        for (int i = 0; i < cantidadAsteroides; i++)
                        {
                            string ID = NombreDeAsteroideAleatorio();
                            Console.WriteLine(ID);
                            metales.GenerarComposicionMineral();
                            Console.WriteLine("");
                        }

                        // Informe del sistema actual
                        Console.WriteLine($"\nEN EL SISTEMA {sistemaAleatorio} SE MINARON {cantidadAsteroides} ASTEROIDES");
                        metales.MostrarTotales();
                        Console.WriteLine("Desea continuar al siguiente sistema o salir del programa?\n1 _ Continuar al siguiente Sistema.\n2 _ Terminar programa.\n");

                    }
                    else
                    {
                        Console.WriteLine("Opción ingresada no válida.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }
            }

            // Informe general
            metales.MostrarMensajeSalida();
        }

    }
}
