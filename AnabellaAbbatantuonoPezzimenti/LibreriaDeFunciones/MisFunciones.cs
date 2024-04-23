namespace LibreriaDeFunciones
{
    public static class MisFunciones
    {
        public static int PedirEntero(string mensaje, string mensajeError)
        {
            int numeroValido;
            string numeroLedido;
            numeroLedido = PedirCadena(mensaje);

            while (!int.TryParse(numeroLedido, out numeroValido))
            {
                Console.WriteLine(mensajeError);
                numeroLedido = PedirCadena(mensaje);
            }
            return numeroValido;
        }

        public static string PedirCadena(string mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine();
        }

        public static void ImprimirArray(string titulo, int[] misNumeros)
        {
            Console.WriteLine(titulo);
            foreach (int numero in misNumeros)
            {
                Console.WriteLine(numero);
            }
        }

            public static int SumaValoresArrayEnteros(int[] misNumeros)
        {
            int suma = 0;
            foreach (int numero in misNumeros)
            {
                suma += numero;
            }

            return suma;
        }

        public static double CalcularPromedioArrayEnteros(int[] misNumeros)
        {
            int suma = 0;
            double resultado;
            foreach (int numero in misNumeros)
            {
                suma += numero;
            }

            resultado = (double)suma / misNumeros.Length;

            return resultado;
        }

        public static /*este es el retorno*/int[] CargarArrayDeEnteros(int cantidad  /*aca sabemos que recibe y se llama parametros*/)
        {
            int[] numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = PedirEntero($"Ingrese el numero {i + 1} de {cantidad}: ", "EL dato ingresado no es numerico");
            }
            return numeros;
        }

        public static void ImprimirArrayAlreves(string titulo, int[] misNumeros)
        {
            Array.Reverse(misNumeros);
            Console.WriteLine(titulo);
            foreach (int numero in misNumeros)
            {
                Console.WriteLine(numero);
            }
        }

        public static int[] OrdenarPorCriterio(int[] datos, bool ordenarMenor)
        {
            int aux;

            for (int i = 0; i < datos.Length; i++)
            {
                for (int j = i + 1; j < datos.Length; j++)
                {

                    if ((ordenarMenor == true && datos[i] > datos[j]) || (ordenarMenor == false && datos[i] < datos[j]))
                    {
                        aux = datos[i];
                        datos[i] = datos[j];
                        datos[j] = aux;
                    }

                }
            }
            return datos;
        }

        public static int[] MostrarPorCriterio(string mensaje, int[] vector, bool mostrarPositivo)
        {
            Console.WriteLine(mensaje);
            foreach (int numero in vector)
            {
                if ((mostrarPositivo == true && numero > 0) || (mostrarPositivo == false && numero < 0))
                {
                    Console.WriteLine(numero);
                }
            }
            return vector;
        }

        // averiguar si son numeros primos                                  
        public static bool EsPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)  //use esta forma de iterar ya que covenia iterar hasta la raiz cuadrada del número.
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;

        }

        // ingreso - Suma y promedio de array --> Se pide por parametro la cantidad de numeros que llevara este array
        public static int[] IngresoSumaPromedioArray(int cantidad)
        {

            int[] array = new int[cantidad];
            int sumaArray = 0;
            int promedioArray = 0;

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"ingreses el {i + 1}° número: ");
                array[i] = int.Parse(Console.ReadLine());
                sumaArray += array[i];

            }

            promedioArray = sumaArray / cantidad;
            Console.WriteLine($"La suma de los numeros ingresados al array es de {sumaArray}");
            Console.WriteLine($"El promedio de los numeros ingresados al array es de {promedioArray}");


            return array;
        }

            // que no reciben nada y no retornan nada.
            public static void Saludar()
        {
            Console.Write("Ingrese su nombre: ");
            Console.WriteLine($"Bienvenido: {Console.ReadLine()}");
        }

        // crear una funcion que pida el ingreso de un numero entero con un rango maximo y un rango minimo y lo retorne

        public static int PedirEnteroConRango(string mensaje, string mensajeError, int maximo, int minimo)
        {
            int numeroValido = 0;
            string numeroLedido;
            Console.Write(mensaje);
            numeroLedido = Console.ReadLine();
            while (!EsNumerico(numeroLedido) || (int.Parse(numeroLedido) > maximo || int.Parse(numeroLedido) < minimo))
            {
                Console.WriteLine(mensajeError);
                Console.Write(mensaje);
                numeroLedido = Console.ReadLine();
            }
            numeroValido = int.Parse(numeroLedido);
            return numeroValido;
        }

        public static bool EsNumerico(string dato)
        {
            bool esNumerico = true;
            foreach (char digito in dato)
            {
                if (!char.IsDigit(digito))
                {
                    esNumerico = false;
                    break;
                }
            }
            return esNumerico;
        }

        public static int PedirEnteroConRangoV2(string mensaje, string mensajeError, int maximo, int minimo)
        {
            int numeroValido;
            string numeroLedido;
            numeroLedido = PedirCadena(mensaje);

            while (!int.TryParse(numeroLedido, out numeroValido) || (numeroValido > maximo || numeroValido < minimo))
            {
                Console.WriteLine(mensajeError);
                numeroLedido = PedirCadena(mensaje);
            }
            return numeroValido;
        }

    }
}