using System;
using CorEscuela.Entidades;

namespace ETAPA1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi School", 2012);
            escuela.Pais = "Colombia";
            escuela.Ciudad  = "Bogota";
            escuela.TipoEscuela = TiposEscuela.Primaria;
            Console.WriteLine(escuela);
        }
    }
}
