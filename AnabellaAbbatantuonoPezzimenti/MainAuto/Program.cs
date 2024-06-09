using LibreriaDeAutos;
using System.Timers;

namespace MainAuto
{
    internal class MainAutos
    {
        static void Main(string[] args)
        {

            bool puedeAvanzar;
            int seleccionarKilometros = 0;
            int contarRepeticiones = 0;

            Auto auto1 = new Auto("Peugeout", 54, "gris metalizado");
            Auto auto2 = new Auto("Toyota", 54, "blanco");
            Auto auto3 = new Auto("Ford", 10, "negro");

            List<Auto> listaDeAutos = new List<Auto>();
            listaDeAutos.Add(auto1);
            listaDeAutos.Add(auto2);
            listaDeAutos.Add(auto3);

            foreach (Auto auto in listaDeAutos)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(auto.AutoToString());
                Console.ResetColor();
            }

            Console.WriteLine("--------------------------------------");


            Console.WriteLine($"Usted esta usando el auto de marca: {auto1.GetMarca()}");
            Console.WriteLine("Cuantos kilometros desea avanzar? ");
            seleccionarKilometros = int.Parse(Console.ReadLine());

            do
            {

                Console.WriteLine($"Usted intento avanzar {seleccionarKilometros}KM. En este momento tiene {auto1.GetCantCombustible()} litros");
                puedeAvanzar = auto1.Avanzar(seleccionarKilometros);

                if (puedeAvanzar)
                {
                    contarRepeticiones++;
                }
                else
                {
                    Console.WriteLine("Ya no puede gastar mas combustible para esa cantidad de kilometros");
                }

            } while (puedeAvanzar);

            Console.WriteLine("-------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"El auto de marca: {auto1.GetMarca()} quedo con: {auto1.GetCantCombustible()} litros de combustible ");
            Console.WriteLine($"El auto avanzo {contarRepeticiones} veces y avanzo {seleccionarKilometros}KM por ves");
            Console.ResetColor();


        }
    }
}
