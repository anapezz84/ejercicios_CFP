namespace Ejercicio_04
{ 
// Ingresar 5 números enteros, calcular y mostrar el promedio.

    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroUnoTexto;
            string numeroDosTexto;
            string numeroTresTexto;
            string numeroCuatroTexto;
            string numeroCincoTexto;
            int numeroUno;
            int numeroDos;
            int numeroTres;
            int numeroCuatro;
            int numeroCinco;
            float promedio;

            Console.WriteLine(" Bienvenido, por favor ingrese el primer numero");
            numeroUnoTexto = Console.ReadLine();
            numeroUno = int.Parse (numeroUnoTexto);

            Console.WriteLine(" Bienvenido, por favor ingrese el segundo numero");
            numeroDosTexto = Console.ReadLine();
            numeroDos = int.Parse(numeroDosTexto); 
            
            Console.WriteLine(" Bienvenido, por favor ingrese el tercer numero");
            numeroTresTexto = Console.ReadLine();
            numeroTres = int.Parse(numeroTresTexto);

            Console.WriteLine(" Bienvenido, por favor ingrese el cuarto numero");
            numeroCuatroTexto = Console.ReadLine();
            numeroCuatro = int.Parse(numeroCuatroTexto);

            Console.WriteLine(" Bienvenido, por favor ingrese el quinto numero");
            numeroCincoTexto = Console.ReadLine();
            numeroCinco = int.Parse(numeroCincoTexto);

            promedio = (numeroUno + numeroDos + numeroTres + numeroCuatro + numeroCinco)/5;

            Console.WriteLine($"El promedio de los cinco numeros es: {promedio}");


        }
    }
}
