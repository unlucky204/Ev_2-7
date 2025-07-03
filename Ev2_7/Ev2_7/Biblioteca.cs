using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev2_7
{
    public class Biblioteca
    {
        public List<Ejemplar> Ejemplares = new List<Ejemplar>();
        public List<Prestamo> Prestamos = new List<Prestamo>();
        public void RegistrarEjemplar()
        {
            Ejemplar ejemplar;
            Console.WriteLine("Ingrese el tipo de ejemplar");
            Console.WriteLine("1.DVD");
            Console.WriteLine("2.Libro");
            Console.WriteLine("3.Revista");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    ejemplar = new Dvd();
                    Ejemplares.Add(ejemplar.CrearEjemplar());
                    Console.WriteLine("DVD registrado");

                    break;
                case 2:
                    ejemplar = new Libro();
                    Ejemplares.Add(ejemplar.CrearEjemplar());
                    Console.WriteLine("Libro registrado");
                    break;
                case 3:
                    ejemplar = new Revista();
                    Ejemplares.Add(ejemplar.CrearEjemplar());
                    Console.WriteLine("Revista registrado");
                    break;
                default:
                    break;
            }
        }
        public void RegistrarPrestamos(Ejemplar ejemplar)
        {
            Prestamo prestamo = new Prestamo();
            prestamo.CodigoEjemplar = ejemplar.Codigo;
            Console.WriteLine("Ingrse la fecha");
            prestamo.Fecha = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrse la fecha de devolucion");
            prestamo.FechaDev = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrse el nombre");
            prestamo.Socio = Console.ReadLine();
            prestamo.Devuelto = false;
            ejemplar.prestado = true;
            Prestamos.Add(prestamo);
            Console.WriteLine("prestamo registrado");
        }
        public void RegistrarDevolucion(Ejemplar ejemplar)
        {
            ejemplar.prestado = false;
            foreach (Prestamo prestamo in Prestamos)
            {
                if (ejemplar.Codigo == prestamo.CodigoEjemplar)
                {
                    prestamo.Devuelto = true;
                    Console.WriteLine("devolucion registrado");
                }
            }
            
        }
        public void ConsultarDisp(Ejemplar ejemplar)
        {
            if (ejemplar.prestado == true)
            {
                Console.WriteLine("Ejemplar prestado");
            }
            else
                Console.WriteLine("Ejemplar disponible ");

        }
        public void EjempPrestados()
        {
            int i = 1;
            foreach (Ejemplar ejemplar in Ejemplares)
            {
                if (ejemplar.prestado == true)
                {
                    Console.WriteLine($"{i}.{ejemplar.Titulo}");
                    i++;
                }
            }
        }

        public void EjempNoDevueltos()
        {
            int i = 1;
            DateTime fecha = DateTime.Now;
            foreach (Prestamo prestamo in Prestamos)
            {
                if (prestamo.FechaDev <= fecha && prestamo.Devuelto == false)
                {
                    foreach (Ejemplar ejemplar in Ejemplares)
                    {
                        if (ejemplar.Codigo == prestamo.CodigoEjemplar)
                        {
                            Console.WriteLine($"{i}.{ejemplar.Titulo} | Esta prestado");
                            i++;
                        }
                    }
                }
            }
        }
    }
}
