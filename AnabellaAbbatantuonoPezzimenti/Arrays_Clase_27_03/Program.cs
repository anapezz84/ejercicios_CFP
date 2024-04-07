namespace Arrays_clase_27_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] miCadena = new string[5]; // "conjunto de palabras, coleccion de palabras" "20/10/1982" "holalalala" "Pedro" "12345671"
             
            char[] otraCadena = new char[5];  //'a' '$' '5' '-' 'l'

            int[] arrayNumerico = new int[5]; // 1 - 2 - 3 - 4 - 5214    (solo números)
            // Declarar todas juntas
            // string [] miCadena
            miCadena[0] = "20/10/1982";
            miCadena[1] = "conjunto de palabras";
            miCadena[2] = "holalalala";
            miCadena[3] = "12345671";
            miCadena[4] = "Pedro";
            // Console.WriteLine(miCadena); system.string[] muestra 

            Console.WriteLine(miCadena[0]);
            Console.WriteLine(miCadena[1]);
            Console.WriteLine(miCadena[2]);
            Console.WriteLine(miCadena[3]);
            Console.WriteLine(miCadena[4]);

            //Console.Writeline($"(micadena[0]}, (micadena[1]},(micadena[2]},(micadena[3]},(micadena[4]},);
            int largo;
            largo = miCadena.Length;

            for (int i = 0; i < largo; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(miCadena[i]);
            }




        }
    }
}
