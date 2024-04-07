namespace Strings_Ejercicio_03
{
    internal class Strings_Ejercicio_03
    {
        static void Main(string[] args)
        {

            // 3.Pedir el ingreso de una palabra y reemplazar todas las letras A por un carácter especial(* , & , etc).
            // Ej: Manzana->M * nz * n *.

            string palabra;
            string palabraModificada = "";

            Console.WriteLine("Bienvenido/a,ingrese una palabra por favor");
            palabra = Console.ReadLine();

            foreach (char letra in palabra)
            {
                if (letra == 'a')
                {
                    palabraModificada += '*';
                }
                else
                {
                    palabraModificada += letra;
                }
            }

            Console.WriteLine($"La palabra que elegiste es {palabra}");
            Console.WriteLine($"La palabra modificada queda asi: {palabraModificada}");

        }
    }
}