namespace Strings_Ejercicio_04
{
    internal class Strings_Ejercicio_04
    {
        static void Main(string[] args)
        {
            // 4.Del string 0000001234500000000 conseguir quedarse con el string 12345 y
            // Mostrarlo por pantalla.


            string palabra = "0000001234500000000";

            Console.WriteLine(palabra.Trim('0'));

            //Console.WriteLine(palabra.TrimStart('0'));

            //Console.WriteLine(palabra.TrimEnd('0'));


            //string numeroSinCeros = "";

            //foreach (char numero in numeros)
            //{
            //    if (numero != '0')
            //    {
            //        numeroSinCeros += numero;
            //    }
            //}

            //Console.WriteLine(numeroSinCeros);
        }
    }
}