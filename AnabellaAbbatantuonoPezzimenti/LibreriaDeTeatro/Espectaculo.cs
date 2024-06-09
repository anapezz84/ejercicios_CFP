namespace LibreriaDeTeatro
{
    public class Espectaculo
    {

        public string nombre;
        public string director;
        public int anio;
        public string genero;
        public int entradasVendidas;
        public int lugaresMaximos;

        public Espectaculo(string nombre, string director, int anio, string genero, int entradasVendidas, int lugaresMaximos)
        {
            this.nombre = nombre;
            this.director = director;
            this.anio = anio;
            this.genero = genero;
            this.lugaresMaximos = 700;
            this.entradasVendidas = 0;
        }

        public string GetNombre()
        {
            return nombre;
        }
        public string GetDirector()
        {
            return director;
        }
        public int GetAnio()
        {
            return anio;
        }
        public string GetGenero()
        {
            return genero;
        }
        public int GetEntradasVendidas()
        {
            return entradasVendidas;
        }
        public int GetLugaresMaximos()
        {
            return lugaresMaximos;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetDirector(string director)
        {
            this.director = director;
        }
        public void SetAnio(int anio)
        {
            this.anio = anio;
        }
        public void SetGenero(string genero)
        {
            this.genero = genero;
        }
        //Comportamientos:
        public string EspectaculoToString()
        {
            return $"nombre:{nombre}-director:{director}- anio:{anio}-genero:{genero}-entradasVendidas:{entradasVendidas}-lugaresMaximos:{lugaresMaximos}";

        }

        public bool SeguirComprando(int cantidad)
        {
            bool seguirComprando = false;
            if ((this.lugaresMaximos > this.entradasVendidas) && (this.entradasVendidas + cantidad <= lugaresMaximos))
            {
                this.entradasVendidas += cantidad;
                seguirComprando = true;
            }
            return seguirComprando;
        }

        public void VenderEntrada(int cantidadEntradasAComprar)
        {
            this.lugaresMaximos = this.lugaresMaximos - cantidadEntradasAComprar;
        }
    }
}

