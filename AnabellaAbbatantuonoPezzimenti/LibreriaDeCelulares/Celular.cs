namespace LibreriaDeCelulares
{
    public class Celular
    {
        //Atributos:(van a ser privados en este caso -si no le pongo nada asume que son privados)

        private string Marca;
        private string Modelo;
        private string Color;
        private double TamañoPantalla;
        private int CapacidadBateria;

        //Constructor:el unico metodo que no tenia retorno (void)
        //constructor va a ser de instancia
        //no tiene retorno y lleva siempre el nombre de la clase
        //puedo tener varios constructores pero respetando los parametros
        public Celular(string marca, string modelo, string color, double tamañoPantalla, int capacidadBateria)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Color = color;
            this.TamañoPantalla = tamañoPantalla;
            this.CapacidadBateria = capacidadBateria;
        }
        //Metodos Getters y Setters-> Permitir consultar(get)
        //y/o modificar atributos(set insertar o agregar)
        //tienen que hacer referencia al atributo con el q estan trabajando
        public string GetMarca()
        {
            return Marca;
        }
        public string GetModelo()
        {
            return Modelo;
        }
        public string GetColor()
        {
            return Color;
        }
        public double GetTamañoPantalla()
        {
            return TamañoPantalla;
        }
        public int GetCapacidadBateria()
        {
            return CapacidadBateria;
        }
        // los set no tienen retorno;
        public void RealizarLlamada(string numero)
        {
            Console.WriteLine($"Llamando al numero {numero} 1150202545");
        }
        public void EnviarMensaje(string numero, string mensaje)
        {
            Console.WriteLine($"Enviando mensaje a {numero}: {mensaje}");
        }
        //Comportamientos:
        public string CelularToString()
        {
            return $"Marca:{Marca}- Modelo:{Modelo}- Color:{Color}- TamañoPantalla:{TamañoPantalla}- CapacidadBateria:{CapacidadBateria}";

        }

        public void Encender()
        {
            Console.WriteLine("Encendiendo el celular 1150202545"); 
        } 

        public void Apagar()
        {
            Console.WriteLine("Apagando el celular 1150202545");
        }

        public void CargarBateria(int porcentaje)
        {
            Console.WriteLine($"Cargando la bateria al {porcentaje}% 100");
        }
    }
}
