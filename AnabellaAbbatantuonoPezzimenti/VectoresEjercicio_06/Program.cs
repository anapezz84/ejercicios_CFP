using LibreriaDeFunciones;

namespace VectoresEjercicio_06
{
    internal class VectoresEjercicio_06
    {
        static void Main(string[] args)
        {
            /*
             Ingresar números en un vector, pueden ser positivos o negativos. 
             Mostrar los negativos de forma creciente y los positivos de forma decreciente.
             Ejemplo: 
             Vector ingresado: {5, 1, -9, -1, 9, 3, -2, 2}
             Vector ordenado: {-9, -2, -1, 9, 5, 3, 2, 1}
             */

            int[] misNumeros = MisFunciones.CargarArrayDeEnteros(8);

            MisFunciones.OrdenarMenor(misNumeros);
            Console.WriteLine()


            MisFunciones.OrdenarPorCriterio(misNumeros, false);
            MisFunciones.MostrarPorCriterio("Negativos en forma creciente", misNumeros, false);



        }
    }
}