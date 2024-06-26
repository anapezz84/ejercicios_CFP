using LibreriaVehiculos;

namespace ConsoleVehiculos
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Crear instancia de moto y coche
            //Llamar a los metodos Conducir() y MostrarInfo()
            //Utilizar GetType() y el casteo para llamar a los
            //métodos específicos de las  clases derivadas(AbrirMaletero() y HacerCaballito()).

            Vehiculo coche1 = new Coche("Fiat", "2020", 4, 200);
            Coche coche2 = new Coche("Peugeot", "2015", 5, 150);
            Vehiculo moto1 = new Moto("Honda", "2021", "Carreras", 125);
            Moto moto2 = new Moto("Yamaha", "1999", "Paseo", 250);

            List<Vehiculo> MisVehiculos = new List<Vehiculo>()
            { coche1, coche2, moto1, moto2};

            foreach (var item in MisVehiculos)
            {
                Console.WriteLine(item.Conducir());
            }

            Console.WriteLine("---------");

            foreach (var item in MisVehiculos)
            {
                Console.WriteLine(item.MostrarInfo());
            }

            foreach (var item in MisVehiculos)
            {
                if (item.GetType() == typeof(Moto))
                {
                    Console.WriteLine(((Moto)item).HacerCaballito());
                }
                else if (item.GetType() == typeof(Coche))
                {
                    Console.WriteLine(((Coche)item).AbrirMaletero());
                }
            }
        }
    }
}