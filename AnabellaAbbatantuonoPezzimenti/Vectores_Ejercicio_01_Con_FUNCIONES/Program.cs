namespace Vectores_Ejercicio_01_con_FUNCIONES
{
    internal class Vector_Funcion_Ejercicio_01
    {
        static void Main(string[] args)
        {

            //Cargar un vector de enteros de 5 elementos y mostrarlo.

            int[] numeros = CargarArray(5);

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

        }

        static int[] CargarArray(int cantidad)
        {

            int[] array = new int[cantidad];

            Console.WriteLine($"Ingrese {cantidad} números ");

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"{i + 1} de {cantidad}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }
    }
}
