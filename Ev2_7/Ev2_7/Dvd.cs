using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev2_7
{
    public class Dvd : Ejemplar
    {
        public int Duracion { get; set; }

        public override Ejemplar CrearEjemplar()
        {
            Dvd dvd = new Dvd();
            Console.WriteLine("Ingrese codigo");
            dvd.Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese titulo");
            dvd.Titulo = Console.ReadLine();
            Console.WriteLine("Ingrese autor");
            dvd.Autor = Console.ReadLine();
            Console.WriteLine("Ingrese genero");
            dvd.Genero = Console.ReadLine();
            Console.WriteLine("Ingrese Duracion");
            dvd.Duracion = int.Parse(Console.ReadLine());
            return dvd;
        }
        public override void ToString()
        {
            Console.WriteLine($"titulo {this.Titulo}");
            Console.WriteLine($"codigo {this.Codigo}");
            Console.WriteLine($"duracion {this.Duracion}");
            Console.WriteLine($"Prestado {this.prestado}");
        }

    }
}
