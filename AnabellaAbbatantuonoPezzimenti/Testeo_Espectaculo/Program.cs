using LibreriaDeTeatro;

namespace Testeo_Espectaculo
{
    internal class Program
    {
        static Espectaculo espectaculo1;
        static Espectaculo espectaculo2;
        static Espectaculo espectaculo3;
        static Espectaculo espectaculo4;
        static Espectaculo espectaculo5;

        static void Main(string[] args)
        {

            Espectaculo espectaculo = new Espectaculo();
            espectaculo1 = new Espectaculo1("TOOTSIE", "Nicolas Vasquez", 2023, "Comedia Musical");
            espectaculo2 = new Espectaculo2("Moldavsky: Lo mejor de mi", "Roberto Moldavsky", 2024, "Unipersonal");
            espectaculo3 = new Espectaculo3("STRAVAGANZA", "Flavio Mendoza", 2020, "Comedia Musical");
            espectaculo4 = new Espectaculo4("Big Bang Show", "Martin Bossi", 2019, "Unipersonal Humoristico");
            espectaculo5 = new Espectaculo5("Bossi Live Comedy", "Martin Bossi", 2023, "Music Hall");

            espectaculo.AgregarEspectaculo(espectaculo1);
            espectaculo.AgregarEspectaculo(espectaculo2);
            espectaculo.AgregarEspectaculo(espectaculo3);
            espectaculo.AgregarEspectaculo(espectaculo4);
            espectaculo.AgregarEspectaculo(espectaculo5);


            Console.WriteLine("Bienvenido/a al TEATRO METROPOLITAN!");
            Console.WriteLine("-----CARTELERA-----");
            espectaculo.MostrarEspectaculo();
            Console.WriteLine("-------------------");

            ComprarEntradas();

            Console.Clear();
            Console.WriteLine("Ventas: ");
            espectaculo.MostrarVentas();
        }

        public static void ComprarEntradas()
        {
            string seguirComprando = string.Empty;
            int seleccion = 0;
            int cantidadEntradas = 0;

            do
            {

                Console.WriteLine("Seleccione que espectaculo desea ver?");
                Console.WriteLine($"(1) {espectaculo1.nombre} (2) {espectaculo2.nombre} (3) {espectaculo3.nombre} (4) {espectaculo4.nombre} (5) {espectaculo5.nombre}");
                seleccion = int.Parse(Console.ReadLine());
                Console.WriteLine("Cuantas entradas desea ?");
                cantidadEntradas = int.Parse(Console.ReadLine());

                switch (seleccion)
                {
                    case 1:

                        if (cantidadEntradas > espectaculo1.lugaresMaximos)
                        {
                            Console.WriteLine("NO HAY SUFICIENTE CANTIDAD DE ENTRADAS");
                        }
                        else
                        {
                            Console.WriteLine($"compro {cantidadEntradas} de entrada/s para {espectaculo1.nombre}");
                            espectaculo1.entradasVendidas += cantidadEntradas;
                            espectaculo1.lugaresMaximos -= cantidadEntradas;

                        }
                        break;

                    case 2:
                        if (cantidadEntradas > espectaculo2.lugaresMaximos)
                        {
                            Console.WriteLine("NO HAY SUFICIENTE CANTIDAD DE ENTRADAS");
                        }
                        else
                        {
                            Console.WriteLine($"compro {cantidadEntradas} de entrada/s para {espectaculo2.nombre}");
                            espectaculo2.entradasVendidas += cantidadEntradas;
                            espectaculo2.lugaresMaximos -= cantidadEntradas;

                        }
                        break;

                    case 3:
                        if (cantidadEntradas > espectaculo3.lugaresMaximos)
                        {
                            Console.WriteLine("NO HAY SUFICIENTE CANTIDAD DE ENTRADAS");
                        }
                        else
                        {
                            Console.WriteLine($"compro {cantidadEntradas} de entrada/s para {espectaculo3.nombre}");
                            espectaculo3.entradasVendidas += cantidadEntradas;
                            espectaculo3.lugaresMaximos -= cantidadEntradas;

                        }
                        break;

                    case 4:
                        if (cantidadEntradas > espectaculo4.lugaresMaximos)
                        {
                            Console.WriteLine("NO HAY SUFICIENTE CANTIDAD DE ENTRADAS");
                        }
                        else
                        {
                            Console.WriteLine($"compro {cantidadEntradas} de entrada/s para {espectaculo4.nombre}");
                            espectaculo4.entradasVendidas += cantidadEntradas;
                            espectaculo4.lugaresMaximos -= cantidadEntradas;

                        }
                        break;

                    case 5:
                        if (cantidadEntradas > espectaculo5.lugaresMaximos)
                        {
                            Console.WriteLine("NO HAY SUFICIENTE CANTIDAD DE ENTRADAS");
                        }
                        else
                        {
                            Console.WriteLine($"compro {cantidadEntradas} de entrada/s para {espectaculo5.nombre}");
                            espectaculo5.entradasVendidas += cantidadEntradas;
                            espectaculo5.lugaresMaximos -= cantidadEntradas;

                        }
                        break;
                }

                Console.WriteLine("Seguir comprando?");
                seguirComprando = Console.ReadLine();

            } while (seguirComprando == "s");

        }
    }


}