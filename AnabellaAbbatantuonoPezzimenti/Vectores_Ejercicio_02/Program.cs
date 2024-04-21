using System.Numerics;

namespace Vectores_Ejercicio_02
{
    internal class Vectores_Ejercicio_02
    {
        static void Main(string[] args)
        {

            //Cargar un vector de enteros de 5 elementos, sumar los valores y mostrarlo.


            int[] numero = new int[5];
            int sumaArray = 0;

            Console.WriteLine($"Bienvenido/a, ingresa {numero.Length} numero/s");


            for (int i = 0; i < numero.Length; i++)
            {
                Console.Write($"{i + 1}° número: ");
                numero[i] = int.Parse(Console.ReadLine());
                sumaArray += numero[i];
            }

            Console.WriteLine($"La suma del array es: {sumaArray}");
            Console.WriteLine("Los numeros del array son: ");

            foreach (var num in numero)
            {
                Console.Write($"{num} ");
            }

        }
    }
}
