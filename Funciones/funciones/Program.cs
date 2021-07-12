using System;

namespace funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno (1, "Alexha", "Betsabe");
            Alumno b = new Alumno (2, "Irving", "Antonio");
            
            a.inactivarAlumno();

            Console.WriteLine(a.nombreCompleto());
            Console.WriteLine(b.nombreCompleto());

            a.activarAlumno();

            Console.WriteLine(a.nombreCompleto());
            Console.WriteLine(b.nombreCompleto());
        }
    }
}
