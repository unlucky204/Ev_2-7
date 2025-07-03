using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev2_7
{
    public class Libro : Ejemplar
    {
        public string ISBN { get; set; }
        public string AnioPubli { get; set; }
        public override Ejemplar CrearEjemplar()
        {
            Libro libro = new Libro();
            Console.WriteLine("Ingrese codigo");
            libro.Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese titulo");
            libro.Titulo = Console.ReadLine();
            Console.WriteLine("Ingrese autor");
            libro.Autor = Console.ReadLine();
            Console.WriteLine("Ingrese genero");
            libro.Genero = Console.ReadLine();
            Console.WriteLine("Ingrese ISBN");
            libro.ISBN = Console.ReadLine();
            Console.WriteLine("Ingrese AnioPubli");
            libro.AnioPubli = Console.ReadLine();
            return libro;
        }
        public override void ToString()
        {
            Console.WriteLine($"titulo: {this.Titulo}");
            Console.WriteLine($"codigo: {this.Codigo}");
            Console.WriteLine($"ISBN: {this.ISBN}");
            Console.WriteLine($"Año: {this.AnioPubli}");
            Console.WriteLine($"Prestado: {this.prestado}");
        }
    }
}
