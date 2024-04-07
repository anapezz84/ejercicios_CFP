namespace Array_De_Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] cadenaDeLetras = new char[5]; //'5' - 'A' - '%' - '+' '1' - '4' - ' '

            char[] otraCadena = { 'd', 'i', 'a', };

            int largo;

            largo = cadenaDeLetras.Length;

            cadenaDeLetras[0] = 'h';
            cadenaDeLetras[1] = 'o';
            cadenaDeLetras[2] = 'l';
            cadenaDeLetras[4] = 'a';

            foreach (char dato in cadenaDeLetras)
            {
                Console.WriteLine(dato);
            }
            {

            }
        }
    }
}