using LibreriaDeCuentas;

namespace testeoCuentas
{
    internal class TesteoCuentas
    {
        static void Main(string[] args)
        {
            Cuentas cuenta1 = new Cuentas("Anabella Abbatantuono Pezzimenti", "Sueldo", 320000);
            Cuentas cuenta2 = new Cuentas("Liliana Pezzimenti", "Dolares", 200);
            Cuentas cuenta3 = new Cuentas("Ezequiel Perez", "Corriente", 1000);

            Console.WriteLine(cuenta1.CuentaToString());
            Console.WriteLine(cuenta2.CuentaToString());
            Console.WriteLine(cuenta3.CuentaToString());

            cuenta1.IngresarDinero(2525);
            Console.WriteLine("Cuenta 1 con dinero ingresado: ");
            Console.WriteLine(cuenta1.CuentaToString());

            cuenta3.RetirarDinero(1095);
            Console.WriteLine("Cuenta 3 con dinero retirado: ");
            Console.WriteLine(cuenta3.CuentaToString());
        }
    }
}