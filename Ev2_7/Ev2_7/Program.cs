using Ev2_7;

Biblioteca biblioteca = new Biblioteca();
void menu()
{
    int op = 0;
    int cod;
    while (op != 7)
    { Console.WriteLine(@"
---------------------------------------------
1.Registrar un ejemplar
2.Registrar un prestamo
3.Registrar devolucion
4.Consultar disponibilidad
5.Listado de ejemplares pendientes de devolucion
6.Listado de ejemplares prestados   
7.salir
Seleccione una opcion:
------------------------------------------------");
        op = int.Parse(Console.ReadLine());
        switch (op)
        {
            case 1:
                Console.WriteLine("=========================");
                biblioteca.RegistrarEjemplar();
                break;
            case 2:
                Console.WriteLine("=========================");
                Console.WriteLine("ingrese el codigo del libro a prestar");
                cod = int.Parse(Console.ReadLine());
                foreach (Ejemplar e in biblioteca.Ejemplares)
                {
                    if (e.Codigo == cod)
                    {
                        biblioteca.RegistrarPrestamos(e);
                    }
                }
                break;
            case 3:
                Console.WriteLine("=========================");
                Console.WriteLine("ingrese el codigo del libro a devolver");
                cod = int.Parse(Console.ReadLine());
                foreach (Ejemplar e in biblioteca.Ejemplares)
                {
                    if (e.Codigo == cod)
                    {
                        biblioteca.RegistrarDevolucion(e);
                    }
                }
                break;
            case 4:
                Console.WriteLine("=========================");
                Console.WriteLine("ingrese el codigo del libro a consultar");
                cod = int.Parse(Console.ReadLine());
                foreach (Ejemplar e in biblioteca.Ejemplares)
                {
                    bool existe = false;
                    if (e.Codigo == cod)
                    {
                        biblioteca.ConsultarDisp(e);
                        existe = true;
                        break;
                    }
                    else if (existe = false)
                    {
                        Console.WriteLine("no se encontro el ejemplar");
                    }
                }

                break;
            case 5:
                Console.WriteLine("=========================");
                biblioteca.EjempNoDevueltos();
                break;
            case 6:
                Console.WriteLine("=========================");
                biblioteca.EjempPrestados();
                break;
            default:
                break;


        }
    }
}
menu();




