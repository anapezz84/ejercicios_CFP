﻿namespace Strings_Ejercicio_01_OtraForma
{
    internal class Program 
    {
        static void Main(string[] args)
        {
        // 1.Pedir el ingreso de una palabra, verificar que por lo menos tenga 5 caracteres de no ser así informar, luego mostrar los primeros 3 caracteres.
        // Ej: zapallo->zap

        String palabra;
        do
        {
            Console.Write("Bienvenido/a, por favor ingrese una palabra con mas de 5 caracteres: ");
            palabra = Console.ReadLine();

            if(palabra.Length < 5)
                {
                    Console.WriteLine("La palabra ingresada es muy corta");
                }

        } while (palabra.Length < 5);


            for(int i = 0; i < 3; i++)
            {
                Console.Write(palabra[i]);
            }


           
        }
    }
}
