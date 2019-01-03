namespace CorEscuela.Entidades
{
    class Escuela
    {
        string nombre;

        public string Nombre {
            get { return "Copia: " + nombre; }
            set { nombre= value.ToUpper(); }
        }

        public int AñoDeCreacion { get;set; }
        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

        /* 
        ***********FORMA DE ESCRIBIR EL CONSTRUCTOR***************
        public Escuela(string nombre, int año) { 
            this.nombre = nombre;
            AñoDeCreacion = año;
        }*/

        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);

        public override string ToString() {
            return $"Nombre: {nombre}, Tipo: {TipoEscuela} \nPais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}