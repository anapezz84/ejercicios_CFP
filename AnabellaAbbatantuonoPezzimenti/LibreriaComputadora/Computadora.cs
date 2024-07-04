using System.Text;

namespace LibreriaComputadora
{
    public class Computadora
    {
        private int capacidadDisco;
        private int memoriaRAM;
        private string procesador;
        private List<string> programas;
        private string sistemaOperativo;


        public Computadora(int CapacidadDisco, int MemoriaRAM, string Procesador, string SistemaOperativo)
            :this()
        {
            this.capacidadDisco = CapacidadDisco;
            this.memoriaRAM = MemoriaRAM;
            this.procesador = Procesador;
            this.sistemaOperativo = SistemaOperativo;
        }

        private  Computadora()
        {
            this.programas = new List<string>();
            
        }
        
        public int CapacidadDisco { get => capacidadDisco; }

        public int MemoriaRam {  get => memoriaRAM; }

        public string Procesador { get => procesador; }

        public string SistemaOperativo {  get => sistemaOperativo; }

        public string Programas
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < programas.Count; i++)
                {
                    sb.Append(programas[i]);
                    if (i < programas.Count - 1)
                    {
                        sb.Append('-');
                    }
                }
                return sb.ToString();
            }
        }

        public static List<string> ListadoDeProcesadores()
    }

   
}
