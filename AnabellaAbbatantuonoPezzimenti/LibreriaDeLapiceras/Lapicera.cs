using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Lapicera
    {
        Color color;
        double precio;
        string marca;
        int nivelDeTinta;

        public Color Color { get => color; }
        public double Precio { get => precio; }
        public string Marca { get => marca; }
        public int NivelDeTinta { get => nivelDeTinta; }
        private Lapicera()
        {
            nivelDeTinta = 100;
        }
        public Lapicera(Color color, double precio, string marca) : this()
        {
            this.color = color;
            this.precio = precio;
            this.marca = marca;
        }
        public bool Escribir(int cantLetras)
        {
            bool bandera = false;
            if (cantLetras <= NivelDeTinta)
            {
                nivelDeTinta -= cantLetras;
                bandera = true;
            }
            return bandera;
        }
        public void Recargar()
        {
            nivelDeTinta = 100;
        }
        public override string ToString()
        {
            string mensaje = $"Color:{color.Name} - Precio:{Precio} - Marca:{Marca} - Nivel de tinta:{NivelDeTinta}";
            return mensaje;
        }
    }
}


        //Sobreescribir el metodo ToString() para que muestre todos sus valores.

        //Crear el metodo publicv bool Escribir(int cantLetras), donde cada letra consume un nivel de tinta, el metodo debe verificar si tiene tinta
        //para escribir la cantidad de letas solicitadas por parametro en informara con un true o false si le alcanzo.

        //El metodo public void Recargar() que colocara el nivel a 100 nuevamente.

        //Al igual que hicimos con los formularios de ingresante, crear dos forms, el principal con el datagridview y el boton agregar y
        //el fomrAlta para crear lapiceras, utilizar groupbox, combobox y la mayor variedad de componentes posibles.

