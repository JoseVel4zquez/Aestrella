using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar
{
    class Nodo
    {
        public int X { get; set; }
        public int Y { get; set; }
        public double h { get; set; }
        public double g { get; set; }
        public Nodo[] hijo;
        public int numhijos;
        public Nodo padre;

        //--------------------------------------------------------------
        public Nodo()
        {
            hijo = new Nodo[8];
        }
        //--------------------------------------------------------------
        public double f() { return h + g; }
        //--------------------------------------------------------------
        public double calcular_h(Nodo meta)
        {
            h = Math.Sqrt((meta.X - X) * (meta.X - X) + (meta.Y - Y) * (meta.Y - Y));
            return h;
        }
        //--------------------------------------------------------------

    }
}