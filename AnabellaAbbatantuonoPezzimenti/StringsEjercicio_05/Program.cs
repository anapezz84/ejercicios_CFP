namespace StringsEjercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5.Pedir el ingreso de nombre y apellido separado por un espacio, guardar
            // cada dato en una variable diferente y asegurarse de que respete el formato de
            // la primera letra en mayúscula y el resto en minúsculas, mostrar el apellido y el
            // nombre por separado.
            // Ej: juAN ROBles(primero nombre luego apelido)
            // Imprimir:
            // Apellido: Robles.
            // Nombre: Juan

            string lectura = "aNABelLA PezZIMENTi";

            string[] palabras = lectura.Split(' ');

            char[] vectorNombre = palabras[0].ToLower().ToCharArray();
            char[] vectorApellido = palabras[1].ToLower().ToCharArray();

            vectorApellido[0] = char.ToUpper(vectorApellido[0]);
            vectorNombre[0] = char.ToUpper(vectorNombre[0]);

            string nombre = "";
            string apellido = string.Empty;

            foreach (char letra in vectorNombre)
            {
                nombre += letra;
            }

            foreach (char letra in vectorApellido)
            {
                apellido += letra;
            }
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Apellido: {apellido}");

        }
    }
}
