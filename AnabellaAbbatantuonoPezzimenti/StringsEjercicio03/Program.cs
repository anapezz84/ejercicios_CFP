﻿namespace StringsEjercicio3
{
    internal class StringEjercicio3
    {
        static void Main(string[] args)
        {

            //            3.Pedir el ingreso de una palabra y reemplazar todas las letras A por un carácter especial(* , & , etc).
            //ej: Manzana->M * nz * n *.

            string palabra;

            Console.WriteLine("Escriba una palabra: ");
            palabra = Console.ReadLine();

            char[] letras = palabra.ToCharArray();


            for (int i = 0; i < letras.Length; i++)
            {
                if (letras[i] == 'a')
                {
                    letras[i] = '#';
                }
            }

            foreach (char unaLetra in letras)
            {
                Console.Write(unaLetra);
            }



            //string palabraModificada = "";

            //Console.WriteLine("Ingrese una palabra, por favor");
            //palabra = Console.ReadLine();

            //foreach (char letra in palabra)
            //{
            //    if (letra == 'a')
            //    {
            //        palabraModificada += '*';
            //    } else
            //    {
            //        palabraModificada += letra;
            //    }
            //}

            //Console.WriteLine($"La palabra que elegiste es {palabra}");
            //Console.WriteLine($"La palabra modificada queda asi: {palabraModificada}");



        }
    }
}