namespace String_Ejercicio_01
{
    internal class Program
        //1. Pedir el ingreso de una palabra, verificar que por lo menos tenga 5 caracteres de no ser así informar, luego mostrar los primeros 3 caracteres.
        //ej: zapallo -> zap

    {
        static void Main(string[] args)
        {
            string palabra;
            bool menosCinco = false;

            do
            {
                Console.WriteLine("Bienvenido, por favor ingrese una palabra");
                palabra = Console.ReadLine();
                int largo;
                largo = palabra.Length;
                if (palabra.Length < 5)
                {
                    menosCinco = true;
                    Console.WriteLine("La palabra ingresada no tiene al menos 5 letras");
                }
                else
                {
                    Console.WriteLine($"Las tres primeras letras son: {palabra[0]}{palabra[1]}{palabra[2]}");
                }
            } while (menosCinco == true);

            
        }
    }
}
