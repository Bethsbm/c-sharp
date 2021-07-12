using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a. PrimerNombre = "Maritza";
            a. SegundoNombre = "Betsabe";

            Alumno b = new Alumno();
            b. Id = 2;
            b. PrimerNombre = "Alexha";
            b. SegundoNombre = "Betsabe";

            Alumno c = new Alumno(3);
            b. PrimerNombre = "Kristhian";
            b. SegundoNombre = "Josue";

            Alumno d = new Alumno("Irving","Antonio");

            Console.WriteLine(a.Id);
            Console.WriteLine(b.Id);
            Console.WriteLine(c.Id);
            Console.WriteLine(d.PrimerNombre + " " + d.SegundoNombre);
            
        }
    }
}
