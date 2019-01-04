using System;
using CorEscuela.Entidades;
using static System.Console;

namespace ETAPA1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi School", 2012, TiposEscuela.Preescolar, ciudad:"Bogotá");
            
            var arregloCursos = new Curso[3];

            arregloCursos[0] = new Curso() {
                                    Nombre = "101"            
                                };

            arregloCursos[1] = new Curso() {
                                    Nombre = "201"            
                                };

            var curso3 = new Curso() {
                Nombre = "301"            
            };

            arregloCursos[2] = curso3;  

            escuela.Cursos = arregloCursos;        

            WriteLine(escuela);
            WriteLine("=================");
            imprimirCursosWhile(arregloCursos);
            imprimirCursosDoWhile(arregloCursos);

        }

        private static void imprimirCursosWhile(Curso[] arregloCursos) {
            int cont = 0;
            while (cont < arregloCursos.Length) {
                WriteLine($"Nombre {arregloCursos[cont].Nombre}, Id {arregloCursos[cont].UniqueId}");
                cont++;
            }
        }

        private static void imprimirCursosDoWhile(Curso[] arregloCursos) {
            int cont = 0;
            do {
                Console.WriteLine($"Nombre {arregloCursos[cont].Nombre}, Id {arregloCursos[cont].UniqueId}");
                //cont++;
            } while (cont++ < arregloCursos.Length - 1);
        }

        private static void imprimirCursosFor(Curso[] arregloCursos) {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                
            }
        }
    }
}
