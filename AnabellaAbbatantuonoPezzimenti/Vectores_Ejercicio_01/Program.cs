using System.Numerics;

namespace Vectores_Ejercicio_01
{
    internal class Vectores_Ejercicio_01
    {
        static void Main(string[] args)
        {

            //Cargar un vector de enteros de 5 elementos y mostrarlo.


            Console.WriteLine("Bienvenido/a, ingrese 5 numeros para el array");

            int[] numeros = new int[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"{i + 1}° numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }


            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }


        }
    }
}
