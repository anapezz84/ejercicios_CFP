using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibreriaEmpleados
{
    public abstract class Desarrollador : Empleado
    {
        string lenguajeProgramacion;
        string experiencia;

        public Desarrollador(string nombre, int salario, string departamento, int antiguedad, int numeroEmpleados, string lenguajeProgramacion, string experiencia) : base(nombre, salario, departamento, antiguedad)
        { 
            this.lenguajeProgramacion = lenguajeProgramacion;
            this.experiencia = experiencia;
        }

        public abstract string Trabajar() // public override string Trabajar()
        {
            return "El desarrollador está escribiendo código.";  // return $"{base.Trabajar()} escribiendo codigo";
        }
        public virtual string MostrarInfo()
        {
            return $"Nombre: {nombre} - Salario: {salario} - Departamento: {departamento} - Antiguedad: {antiguedad}";
        }

        public override string CalcularBonificacion()
        {
            return = 0;
        }

        public string DepurarCodigo()
        {

        }

        public abstract string SalarioTotal()
        {
            return = 0;
        }

    }
}
