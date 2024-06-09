using LibreriaEstudiante;
using TesteoAlumno;
namespace TesteoAlumno
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Estudiante estudiante6 = new Estudiante("Carolina", "Soria", "1001");

            //estudiante6.Legajo = "1007";

            Random rand = new Random();

            List<Estudiante> alumnos = new List<Estudiante>
            {
                new Estudiante("Anabella","Pezzimenti","1001"),
                new Estudiante("Roxana", "Brea", "1002"),
                new Estudiante("Viviana", "Zelarrayan", "1003"),
                new Estudiante("Glenny", "Galva", "1004"),
                new Estudiante("Diana", "Halles", "1005")
            };

            foreach (Estudiante a in alumnos)
            {
                a.SetNotaPrimerParcial(rand.Next(1, 10));
                a.SetNotaSegundoParcial(rand.Next(1, 10));
            }


            foreach (Estudiante item in alumnos)
            {
                Console.WriteLine(item.EstudianteToString2());
            }


        }
    }
}
