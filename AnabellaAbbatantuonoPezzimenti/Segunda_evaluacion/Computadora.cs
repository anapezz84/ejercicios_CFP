namespace Segunda_evaluacion
{
    public class Computadora
    {
        int capacidadDisco;
        int memoriaRam;
        string procesador;
        List<string> programas;
        string sistemaOperativo;

        public int CapacidadDisco { get => capacidadDisco;  }
        public int MemoriaRam { get => memoriaRam; }
        public string Procesador { get => procesador; }
        public string SistemaOperativo { get => sistemaOperativo; }

        public string Programas
        {
            get
            {
                string todos = string.Empty;
                for (int i = 0; i < programas.Count; i++)
                {
                    todos += programas[i];
                    if (i < programas.Count - 1)
                    {
                        todos += " - ";
                    }
                }

                return todos;
            }
        }

        private Computadora()
        {
            this.programas = new List<string>();
        }

        public Computadora(int capacidadDisco, int memoriaRam, string procesador, string sistemaOperativo)
            :this()
        {
            this.capacidadDisco = capacidadDisco;
            this.memoriaRam = memoriaRam;
            this.procesador = procesador;
            this.sistemaOperativo = sistemaOperativo;
        }

        public void SetPrograma(string programa)
        {
            this.programas.Add(programa);
        }

        public List<string> GetProgramas()
        {
            return this.programas;
        }

        public static List<string> ListadoDeProcesadores()
        {
            return new List<string>() {
                "I9", "Ryzen 8",
                "I7", "Ryzen 7",
                "I6", "Ryzen 6",
                "I5", "Ryzen 5",
                "I3", "Ryzen 3",
            };
        }
    }
}
