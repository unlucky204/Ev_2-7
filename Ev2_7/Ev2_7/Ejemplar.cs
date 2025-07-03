using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev2_7
{
    public abstract class Ejemplar 
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public bool prestado { get; set; }

        public abstract Ejemplar CrearEjemplar();
        public abstract void ToString();
        
    }
}

