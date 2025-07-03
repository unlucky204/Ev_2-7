using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev2_7
{
    public class Prestamo
    {
        public int CodigoEjemplar { get; set; }
        public DateTime Fecha { get; set; }
        public bool Devuelto { get; set; }
        public DateTime FechaDev { get; set; }
        public string Socio { get; set; }
    }
}
