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
    public abstract class Gerente :Empleado
    {
        int numeroEmpleados;

        public Gerente(string nombre, int salario, string departamento, int antiguedad, int numeroEmpleados) :base(nombre, salario, departamento, antiguedad)
        {
            this.numeroEmpleados = numeroEmpleados;
        }

        public abstract string Trabajar() // public override string Trabajar()
        {
            return $"El gerente está gestionando el departamento";  // return $"{base.Trabajar()} gestionando el departamento";
        }
        public virtual string MostrarInfo()
        {
            return $"Nombre: {nombre} - Salario: {salario} - Departamento: {departamento} - Antiguedad: {antiguedad}";
        }

        public override string CalcularBonificacion()
        {
            return = 0;
        }

        public abstract string Planificar();

        public abstract string SalarioTotal()
        {
            return = 0;
        }

    }
}
