namespace String_Ejercicio_02
{
    internal class Program
    {
     // 2. Pedir el ingreso de una palabra y mostrarla con todos sus caracteres separados por un guión.
     // Ej: Montaña -> M-o-n-t-a-ñ-a.

        static void Main(string[] args)
        {
            string palabra;

            Console.Write("Bienvenido, por favor ingrese una palabra");
            palabra = Console.ReadLine();
            int largo;
            largo = palabra.Length;

            foreach (char letra in palabra)
            {
                Console.Write($"{letra}");
            }
        }
    }
}
