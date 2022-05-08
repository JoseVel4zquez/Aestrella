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
            /*
            var heu= calcular_h(inicio);
            var heu2  = calcular_h(meta);
            Open.Add(inicio);
            double distancia = Distancia();
            
            while (Open.Count>0) {
                for (double i = 0; i < Open.Count; i++)
                {
                    inicio.g = i;
                    inicio.h = heu;
                }
                for (double i = 0; i < Open.Count; i++)
                {
                    meta.g = i;
                    meta.h = heu2;
                }

                Closed.Add(inicio);
                double z = inicio.f();
                double x = meta.f();

                if (inicio.f() == meta.f())
                {
                    
                    MessageBox.Show("Se encontro la meta ");
                    break;
                }

            }*/
            //Open.Add(hijo[3]);

            iniciarListaOpen();

			if (inicio.X == meta.X && inicio.Y == meta.Y)
			{
                MessageBox.Show("Se llego a la meta");
			}
       
        }

        public void iniciarListaOpen()
		{
            inicio.g = 0;
            inicio.h = Distancia(inicio);
            Open.Add(inicio);


			for (numhijos = 0; numhijos < hijo.Length; numhijos++)
			{
                //verificamos si no hay obstaculos en la parte superior
				if( (this.tablero[inicio.X , inicio.Y - 1].Style.BackColor.R == 0) && (this.tablero[inicio.X , inicio.Y - 1].Style.BackColor.B == 0) && (this.tablero[inicio.X , inicio.Y - 1].Style.BackColor.G == 0))

                {

					hijo[numhijos] = new Nodo { peso = f() };
					tablero[inicio.X, inicio.Y - 1].Style.BackColor = Color.Orange;
				}
                //verificamos si no hay obstaculos en la parte superior derecha
                else if ((this.tablero[inicio.X+1, inicio.Y - 1].Style.BackColor.R == 0) && (this.tablero[inicio.X+1, inicio.Y - 1].Style.BackColor.B == 0) && (this.tablero[inicio.X+1, inicio.Y - 1].Style.BackColor.G == 0))

                {
                    hijo[numhijos] = new Nodo { peso = f() };
                    tablero[inicio.X+1, inicio.Y - 1].Style.BackColor = Color.Orange;
                }
                //verificamo si junto al nodo no hay obstaculos
                else if ((this.tablero[inicio.X + 1, inicio.Y].Style.BackColor.R == 0) && (this.tablero[inicio.X + 1, inicio.Y].Style.BackColor.B == 0) && (this.tablero[inicio.X + 1, inicio.Y].Style.BackColor.G == 0))

                {
                    hijo[numhijos] = new Nodo { peso = f() };
                    tablero[inicio.X + 1, inicio.Y].Style.BackColor = Color.Orange;
                }
                //verificamos si en la esquina inferior no hay obstaculos
                else if ((this.tablero[inicio.X+1, inicio.Y + 1].Style.BackColor.R == 0) && (this.tablero[inicio.X+1, inicio.Y + 1].Style.BackColor.B == 0) && (this.tablero[inicio.X+1, inicio.Y + 1].Style.BackColor.G == 0))

                {
                    hijo[numhijos] = new Nodo { peso = f() };
                    tablero[inicio.X+1, inicio.Y + 1].Style.BackColor = Color.Orange;
                }
                //abajo del inicio
                else if ((this.tablero[inicio.X, inicio.Y+1 ].Style.BackColor.R == 0) && (this.tablero[inicio.X , inicio.Y +1].Style.BackColor.B == 0) && (this.tablero[inicio.X, inicio.Y +1].Style.BackColor.G == 0))

                {
                    hijo[numhijos] = new Nodo { peso = f() };
                    tablero[inicio.X, inicio.Y+1 ].Style.BackColor = Color.Orange;
                }
                //
                else if ((this.tablero[inicio.X-1, inicio.Y + 1].Style.BackColor.R == 0) && (this.tablero[inicio.X-1, inicio.Y + 1].Style.BackColor.B == 0) && (this.tablero[inicio.X-1, inicio.Y + 1].Style.BackColor.G == 0))

                {
                    hijo[numhijos] = new Nodo { peso = f() };
                    tablero[inicio.X-1, inicio.Y + 1].Style.BackColor = Color.Orange;
                }
                //atras
                else if ((this.tablero[inicio.X - 1, inicio.Y ].Style.BackColor.R == 0) && (this.tablero[inicio.X - 1, inicio.Y  ].Style.BackColor.B == 0) && (this.tablero[inicio.X - 1, inicio.Y ].Style.BackColor.G == 0))

                {
                    hijo[numhijos] = new Nodo { peso = f() };
                    tablero[inicio.X - 1, inicio.Y ].Style.BackColor = Color.Orange;
                }
                //superior izq
                else if ((this.tablero[inicio.X - 1, inicio.Y-1].Style.BackColor.R == 0) && (this.tablero[inicio.X - 1, inicio.Y-1].Style.BackColor.B == 0) && (this.tablero[inicio.X - 1, inicio.Y-1].Style.BackColor.G == 0))

                {
                    hijo[numhijos] = new Nodo { peso = f() };
                    tablero[inicio.X - 1, inicio.Y-1].Style.BackColor = Color.Orange;
                }

            }
		}



		public double Distancia(Nodo ini)
		{
            double restax = meta.X - ini.X;
            double xcuadradas = Math.Pow(restax,2);
            double ycuadradas = Math.Pow((meta.Y - ini.Y), 2);
            double res = Math.Sqrt((xcuadradas+ycuadradas));

            return res;
		}

       
		
    }
}
