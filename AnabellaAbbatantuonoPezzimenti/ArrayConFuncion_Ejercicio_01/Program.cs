﻿namespace Funcion_03_Practica
{
    internal class ArrayConFuncion_Ejercicio_01
    {
        static void Main(string[] args)
        {

            //Cargar un vector de enteros de 5 elementos y mostrarlo.

            int[] numeros = IngresarEnterosArray(5);

            foreach (var item in numeros)
            {
                Console.Write($"Numero ingresado: ");
                Console.WriteLine(item);
            }


        }

        static int[] IngresarEnterosArray(int cantidad)
        {
            int[] array = new int[cantidad];

            Console.WriteLine($"Bienvenido/a, por favor ingrese: {cantidad} números para su array");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Ingresando array: ");
                array[i] = int.Parse(Console.ReadLine());
            }


            return array;
        }

    }
}
