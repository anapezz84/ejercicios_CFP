using MisClases;

namespace ConsoleClientes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Caja Ahorro", "27-1231733-4");
            cliente1.Apellido = "Pezzimenti";
            cliente1.Nombre = "Liliana";
            cliente1.Edad = 68;

            Clienteplus clienteplus1 = new Clienteplus("Caja Ahorro", "27-30697450-0", 2593);
            clienteplus1.Nombre = "Anabella";
            clienteplus1.Apellido = "Abbatantuono";
            clienteplus1.Edad = 40;

            Console.WriteLine(cliente1.GuardarEnDisco());
            Console.WriteLine(clienteplus1.GuardarEnDisco());

            Console.WriteLine(Cliente.ValidarCUIT(cliente1.Cuit));
            Console.WriteLine(Cliente.ValidarCUIT(clienteplus1.Cuit));

        }
    }
}