using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace AStar
{
    class Nodo
    {
        public int X { get; set; }
        public int Y { get; set; }
        public double h { get; set; }
        public double g { get; set; }
        public double peso { get; set; }
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

        //ese solo se usa para la meta 
        public double calcular_h(Nodo meta)
        {
            h = Math.Sqrt(Math.Pow((X-meta.X),2) + Math.Pow((Y-meta.Y),2));
            return h;
        }
        //--------------------------------------------------------------

        public bool is_obstaculo(DataGridView tablero)
		{
		    if(tablero.CurrentCell.Style.BackColor ==Color.Black)
			{
                return true;
            }
            return false;            
		}

        public void crearHijos(Nodo inicio)
        {
			if (inicio.X - 1 > 0)
			{
                MessageBox.Show("camino en x-1 ");
			}
            else if (inicio.X + 1 > inicio.X )
            {
                MessageBox.Show("camino en x+1 ");
            }else if (inicio.X - 1 > 0 && inicio.Y-1 >0)
			{
                MessageBox.Show("x,y");
			}
            else
			{
                MessageBox.Show("Cerrado");
			}
		}

    }
}