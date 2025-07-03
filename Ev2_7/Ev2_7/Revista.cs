using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev2_7
{
    public class Revista : Ejemplar    
    {
        public DateTime Fecha { get; set; }
        public int Numero { get; set; }
        public override Ejemplar CrearEjemplar()
        {
            Revista revista = new Revista();
            Console.WriteLine("Ingrese codigo");
            revista.Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese titulo");
            revista.Titulo = Console.ReadLine();
            Console.WriteLine("Ingrese autor");
            revista.Autor = Console.ReadLine();
            Console.WriteLine("Ingrese genero");
            revista.Genero = Console.ReadLine();
            Console.WriteLine("Ingrese Fecha");
            revista.Fecha = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero");
            revista.Numero = int.Parse(Console.ReadLine());
            return revista;

        }
        public override void ToString()
        {
            Console.WriteLine($"titulo: {this.Titulo}");
            Console.WriteLine($"codigo: {this.Codigo}");
            Console.WriteLine($"fecha: {this.Fecha}");
            Console.WriteLine($"numero: {this.Numero}");
            Console.WriteLine($"Prestado: {this.prestado}");
        }
    }
}
