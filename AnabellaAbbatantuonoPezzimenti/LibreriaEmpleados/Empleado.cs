using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleados
{
    public abstract class Empleado
    {
        protected string nombre;
        protected double salario;
        protected string departamento;
        protected int antiguedad;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public int Antiguedad { get => antiguedad; set => antiguedad = value; }

        protected Empleado(string nombre, double salario, string departamento, int antiguedad)
        {
            this.Nombre = nombre;
            this.Salario = salario;
            this.Departamento = departamento;
            this.Antiguedad = antiguedad;
        }

        public abstract string Trabajar();
        public virtual string MostrarInfo()
        {
            return $"Nombre: {nombre} - Salario: {salario} - Departamento: {departamento} - Antiguedad: {antiguedad}";
        }

        public virtual double CalcularBonificacion(double salario)
        {
            double bonificacion = 0 * salario;

            return bonificacion;
        }

        public abstract double SalarioTotal();  //retorna la informacion de la suma del salario mas el valor de la bonificacion

        

    }
}
