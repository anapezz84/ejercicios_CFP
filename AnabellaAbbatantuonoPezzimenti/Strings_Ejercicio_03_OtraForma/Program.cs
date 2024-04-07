namespace Strings_Ejercicio_03_OtraForma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 3.Pedir el ingreso de una palabra y reemplazar todas las letras A por un carácter especial(* , & , etc).
            // Ej: Manzana->M * nz * n *.

            //string palabra;

            //Console.Write("Bienvenido/a, por favor escriba una palabra: ");
            //palabra = Console.ReadLine();


            //char[] letras = palabra.ToCharArray();

            //for(int i = 0; i < letras.Length; i++)
            //{
            //    if (letras[i] == 'a')
            //    {
            //        letras[i] = '*';
            //    }
            //}
            //foreach (char unaLetra in letras)
            //{
            //    Console.Write(unaLetra);
            //}

            string palabra;

            Console.Write("Bienvenido/a, por favor escriba una palabra: ");
            palabra = Console.ReadLine();


            char[] letras = palabra.ToCharArray();

            for (int i = 0; i < letras.Length; i++)
            {
                if (letras[i] == 'a')
                {
                    letras[i] = '*';
                }
            }

            string otraPalabra = "";

            foreach (char unaLetra in letras)
            {
                otraPalabra += unaLetra;
            }

            Console.Write(otraPalabra);
        }    
    }
}

        




  
