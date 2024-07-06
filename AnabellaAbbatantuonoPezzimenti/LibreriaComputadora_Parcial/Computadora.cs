using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace LibreriaComputadora_Parcial
{
    public class Computadora
    {
        private int capacidadDisco;
        private int memoriaRam;
        private string procesador;
        private string sistemaOperativo;
        private List<string> programas;

        public int CapacidadDisco { get => capacidadDisco; }
        public int MemoriaRam { get => memoriaRam; }
        public string Procesador { get => procesador; }
        public string SistemaOperativo { get => sistemaOperativo; }
        public string Programas
        {
            get
            {

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < GetProgramas().Count; i++)
                {
                    sb.Append(GetProgramas()[i]);

                    if (i < GetProgramas().Count - 1)
                    {
                        sb.Append(" - ");
                    }

                }

                return sb.ToString();
            }
        }

        private Computadora()
        {
            this.programas = new List<string>();
        }

        public Computadora(int capacidadDisco, int memoriaRam, string procesador, string sistemaOperativo)
            : this()
        {
            this.capacidadDisco = capacidadDisco;
            this.memoriaRam = memoriaRam;
            this.procesador = procesador;
            this.sistemaOperativo = sistemaOperativo;
        }

        public List<string> GetProgramas()
        {
            return programas;
        }

        public void SetPrograma(string programa)
        {
            programas.Add(programa);
        }

        public static List<string> ListadoDeProcesadores()
        {
            return new List<string>() { "Pentium", "Intel inside", "Amd Charly", "Pepe intel", "MacChips" };
        }
    }
}