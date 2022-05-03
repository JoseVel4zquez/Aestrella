using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AStar
{
    class AStar : Nodo
    {
        
        public Nodo inicio;
        public Nodo meta;
        public Nodo calcHeu;
        DataGridView tablero;
        

        List<Nodo> Open, Closed,camino;
        bool termiado = false;
        
        //Constructor
        public AStar(DataGridView Tablero)
        {
            inicio = new Nodo();
            meta = new Nodo();
            calcHeu = new Nodo();
            tablero = Tablero;
            Open = new List<Nodo>();
            Closed = new List<Nodo>();
            camino = new List<Nodo>();

        }

        //------------------------------------------------
        public void empezar()
        {
            
            var heu= calcular_h(inicio);
            meta.h = calcular_h(meta);
            Open.Add(inicio);
            double distancia = Distancia();
            
            while (Open.Count>0) {
                for (int i = 0; i < Open.Count; i++)
                {
                    inicio.g = i;
                    inicio.h = heu;
                }

                Closed.Add(inicio);
                if (inicio.f() == meta.f())
                {
                    
                    MessageBox.Show("Se encontro la meta ");
                    break;
                }

            }
		}

        public void insertarNodo(double[] peso)
		{
            Nodo n = new Nodo();
            //n.hijo = peso[];

			if (padre ==null)
			{
                padre = n;
			}
		}

        public double Distancia()
		{
            double restax = meta.X - inicio.X;
            double xcuadradas = Math.Pow(restax,2);
            double ycuadradas = Math.Pow((meta.Y - inicio.Y), 2);
            double res = Math.Sqrt((xcuadradas+ycuadradas));

            return res;
		}

       
		
    }
}
