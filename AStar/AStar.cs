using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AStar
{
    class AStar
    {
        public Nodo inicio;
        public Nodo meta;
        DataGridView tablero;
        
        List<Nodo> Open,Closed;  
 
        //Constructor
        public AStar(DataGridView Tablero)
        {
            inicio = new Nodo();
            meta = new Nodo();
            tablero = Tablero;
            Open = new List<Nodo>();
            Closed = new List<Nodo>();
        }
     //------------------------------------------------
     public void empezar()
		{
            Open.Add(inicio);
			while (Open.Count>0)
			{

			}
		}
    }
}
