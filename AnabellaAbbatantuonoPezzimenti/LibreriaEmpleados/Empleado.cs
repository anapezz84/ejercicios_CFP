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
    public abstract class Empleado
    {
        protected string nombre;
        protected int salario;
        protected string departamento;
        protected int antiguedad;

        protected Empleado (string nombre, int salario, string departamento, int antiguedad)
        {
            this.nombre = nombre;
            this.salario = salario;
            this.departamento = departamento;
            this.antiguedad = antiguedad;
        }

        public abstract string Trabajar();
        public virtual string MostrarInfo()
        {
            return $"Nombre: {nombre} - Salario: {salario} - Departamento: {departamento} - Antiguedad: {antiguedad}";
        }

        public virtual string CalcularBonificacion()
        {
            return = 0;
        }

        public abstract string SalarioTotal()
        {
            return = 0;
        }

    }
}
