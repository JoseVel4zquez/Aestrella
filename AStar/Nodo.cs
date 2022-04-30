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
        public double f { get; set; }
        public Nodo[] hijo;
        public int numhijos;
        public Nodo padre;
        
        //--------------------------------------------------------------
        public Nodo()
        {
           hijo = new Nodo[8];
        }
        //--------------------------------------------------------------
       
        //--------------------------------------------------------------
        public double calcular_h(Nodo vecinos ,Nodo meta)
        {
            h = Math.Sqrt((vecinos.X-meta.X)*(vecinos.X-meta.X)+(vecinos.Y-meta.Y)*(vecinos.Y-meta.Y));
            return h;
        }
        //--------------------------------------------------------------

    }
}
