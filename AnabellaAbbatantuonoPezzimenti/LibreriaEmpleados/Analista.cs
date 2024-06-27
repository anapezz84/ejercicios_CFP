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
    public abstract class Analista : Empleado
    {
        string especialidad;
        string proyectos;

        public Analista(string nombre, int salario, string departamento, int antiguedad, int numeroEmpleados, string lenguajeProgramacion, string experiencia, string especialidad, string proyectos) : base(nombre, salario, departamento, antiguedad)
        {
            this.especialidad = especialidad;
            this.proyectos = proyectos;
        }

        public abstract string Trabajar() // public override string Trabajar()
        {
            return "El analista está analizando los datos.";  // return $"{base.Trabajar()} analizando los datos";
        }
        public virtual string MostrarInfo()
        {
            return $"Nombre: {nombre} - Salario: {salario} - Departamento: {departamento} - Antiguedad: {antiguedad}";
        }

        public override string CalcularBonificacion()
        {
            return = 0;
        }

        public string 

        public abstract string SalarioTotal()
        {
            return = 0;
        }

    }
}

