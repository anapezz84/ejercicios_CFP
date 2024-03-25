namespace Ejercicio_03
{
    // Ingresar 2 números y mostrar la suma de los mismos.

    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroUnoTexto;
            string numeroDosTexto;
            int numeroUno;
            int numeroDos;
            int resultado;

            Console.WriteLine("Bienvenidos, por favor ingrese un numero ");
            numeroUnoTexto = Console.ReadLine();
            numeroUno = int.Parse(numeroUnoTexto);

            Console.WriteLine(" Por favor ingrese otro numero ");
            numeroDosTexto = Console.ReadLine();
            numeroDos = int.Parse(numeroDosTexto);

            resultado = numeroUno + numeroDos;
            Console.WriteLine($"El resultado de la suma es: = {resultado} ");
        }

    }
    }

