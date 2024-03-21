namespace RepasoCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Al ingresar una edad menor a 18 años y un estado civil distinto a soltero,
            //mostrar el mensaje: “Es muy pequeño para NO ser soltero”.

            int edad;
            string estadoCivil;
            string edadTexto;

            Console.Write("Ingrese su edad");
            edadTexto = Console.ReadLine();

            edad = int.Parse(edadTexto);

            Console.Write("Ingrese su estado civil");
            estadoCivil = Console.ReadLine();

            if (edad < 18 && estadoCivil == "casado") {
                Console.Write("Es muy pequeño para NO ser soltero");
            }

                
        }
    }
}
