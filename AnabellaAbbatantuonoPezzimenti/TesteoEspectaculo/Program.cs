using System;//importamos esta clase para poder imprimir en consola con Console.WriteLine()
using System.Collections.Generic;//importamos esto para poder usar List
using LibreriaDeTeatro;

namespace TesteoEspectaculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool seguirComprando = true;
            int seleccion = 0;

            Espectaculo espectaculo1 = new Espectaculo("TOOTSIE", "Nicolas Vasquez", 2023, "Comedia Musical", 0, 100);
            Espectaculo espectaculo2 = new Espectaculo("Moldavsky: Lo mejor de mi", "Roberto Moldavsky", 2024, "Unipersonal", 0, 200);
            Espectaculo espectaculo3 = new Espectaculo("STRAVAGANZA", "Flavio Mendoza", 2020, "Comedia Musical", 0, 300);
            Espectaculo espectaculo4 = new Espectaculo("Big Bang Show", "Martin Bossi", 2019, "Unipersonal Humoristico", 0, 400);
            Espectaculo espectaculo5 = new Espectaculo("Bossi Live Comedy", "Martin Bossi", 2023, "Music Hall", 0, 500);

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Bievenido/a al TEATRO METROPOLITAN!");

            do
            {
                Console.WriteLine("¿¡Que espectaculo desea ver!?");

                Console.WriteLine("(1) TOOTSIE - (2) Moldavsky: Lo mejor de mi - (3) STRAVAGANZA - (4) Big Bang Show - (5) Bossi Live Comedy");
                seleccion = int.Parse(Console.ReadLine());

                switch (seleccion)
                {
                    case 1:
                        Console.WriteLine("Cuantas entradas desea para 'TOOTSIE' ?");
                        int entradas1 = Convert.ToInt32(Console.ReadLine());
                        if (espectaculo1.SeguirComprando(entradas1))
                        {
                            espectaculo1.VenderEntrada(entradas1);
                            Console.Write("La cantidad de entradas que quedan es: ");
                            Console.WriteLine(espectaculo1.GetLugaresMaximos());
                        }
                        else
                        {
                            Console.WriteLine("No hay asientos disponibles para TOOTSIE...");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Cuantas entradas desea para 'Moldavsky: Lo menjor de mi' ?");
                        int entradas2 = Convert.ToInt32(Console.ReadLine());
                        if (espectaculo2.SeguirComprando(entradas2))
                        {
                            espectaculo2.VenderEntrada(entradas2);
                            Console.Write("La cantidad de entradas que quedan es: ");
                            Console.WriteLine(espectaculo2.GetLugaresMaximos());
                        }
                        else
                        {
                            Console.WriteLine("No hay asientos disponibles para Moldavsky: Lo mejor de mi...");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Cuantas entradas desea para 'STRAVAGANZA' ?");
                        int entradas3 = Convert.ToInt32(Console.ReadLine());
                        if (espectaculo3.SeguirComprando(entradas3))
                        {
                            espectaculo3.VenderEntrada(entradas3);
                            Console.Write("La cantidad de entradas que quedan es: ");
                            Console.WriteLine(espectaculo3.GetLugaresMaximos());
                        }
                        else
                        {
                            Console.WriteLine("No hay asientos disponibles para STRAVAGANZA...");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Cuantas entradas desea para 'Big Bang Show' ?");
                        int entradas4 = Convert.ToInt32(Console.ReadLine());
                        if (espectaculo4.SeguirComprando(entradas4))
                        {
                            espectaculo4.VenderEntrada(entradas4);
                            Console.Write("La cantidad de entradas que quedan es: ");
                            Console.WriteLine(espectaculo4.GetLugaresMaximos());
                        }
                        else
                        {
                            Console.WriteLine("No hay asientos disponibles para Big Bang Show...");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Cuantas entradas desea para 'Bossi Live Comedy' ?");
                        int entradas5 = Convert.ToInt32(Console.ReadLine());
                        if (espectaculo5.SeguirComprando(entradas5))
                        {
                            espectaculo5.VenderEntrada(entradas5);
                            Console.Write("La cantidad de entradas que quedan es: ");
                            Console.WriteLine(espectaculo5.GetLugaresMaximos());
                        }
                        else
                        {
                            Console.WriteLine("No hay asientos disponibles para Bossi Live Comedy...");
                        }
                        break;
                }

                Console.WriteLine("¿Seguir Comprando? (APRETE 'S' PARA CONTINUAR u OTRA TECLA PARA TERMINAR)");
                if (Console.ReadLine().ToLower() != "s")
                {
                    seguirComprando = false;
                }

            } while (seguirComprando);



            Console.WriteLine("---------------------------------");

            List<Espectaculo> listaEspectaculo = new List<Espectaculo>();

            listaEspectaculo.Add(espectaculo1);
            listaEspectaculo.Add(espectaculo2);
            listaEspectaculo.Add(espectaculo3);
            listaEspectaculo.Add(espectaculo4);
            listaEspectaculo.Add(espectaculo5);


            foreach (var item in listaEspectaculo)
            {
                Console.WriteLine(item.EspectaculoToString());
            }

        }
    }
}
