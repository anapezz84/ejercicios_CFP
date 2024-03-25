namespace PrimeraClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            string edadTexto;
            int edadNumerica;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su apellido: ");
            apellido = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            edadTexto = Console.ReadLine();

            edadNumerica = int.Parse(edadTexto);

            //Console.WriteLine("Bienvenido " + nombre + " " + apellido + " ud tiene: " + edadNumerica + " años "); FORMA STANDARD CLASICA DE CONCATENAR

            Console.WriteLine("Bienvenido {0} {1} , usted tiene: {2} años. ", nombre, apellido, edadNumerica); FORMA MAS OPTIMA

            //Console.WriteLine($"Bienvenido {nombre} {apellido} , ud tiene: {edadNumerica} años. "); 


        }
    }
}
