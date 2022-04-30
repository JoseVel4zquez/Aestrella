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
            Open.Add(inicio);
			while (termiado!=true)
			{
				if (Open.Count > 0)
				{
                    var ganador = 0; //índie o posición dentro del array openset del ganador

                    //evaluamos que OpenSet tiene un menor coste / esfuerzo
                    for (int i = 0; i < Open.Count; i++)
                    {
                        if (Open[i].f < Open[ganador].f)
                        {
                            ganador = i;

                        }

                        

                    }
                    var actual = Open[ganador];
					if (actual == meta)
					{
                        var temporal = actual;
                        camino.Add(temporal);

						while (temporal.padre != null)
						{
                            temporal = temporal.padre;
                            camino.Add(temporal);
						}
                        MessageBox.Show("Ya jalo");
                        termiado = true;
					}
					else
					{
                        Closed.Add(actual);
                        var vecinos = actual.hijo;
						
						for (int i =0; i < vecinos.Length;i++)
						{
                            var vecino = vecinos[i];
							if (!Closed.Contains(vecino) && tablero.CurrentCell.Style.BackColor != Color.Black)
							{
                                var tempG = actual.g + 1;
								if (Open.Contains(vecino))
								{
                                    if(tempG < vecino.g)
									{
                                        vecino.g = tempG;
									}
								}
								else
								{
                                    vecino.g = tempG;
                                    Open.Add(vecino);
								}
                                vecino.h = calcular_h(vecino,meta);
                                vecino.f = vecino.g + vecino.h;

                                vecino.padre = actual;
                            }
						}

                        
                    }

				}
				else
				{
                    MessageBox.Show("No hay caminos");
                    termiado = true;
				}
				
			}
		}
    }
}
