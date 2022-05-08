using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AStar
{
    public partial class Form1 : Form
    { int sizeTablero;
    AStar a;  
        public Form1()
        {
            InitializeComponent();
            a= new AStar(tablero);  //Invocamos al Constructor de la clase Star
            sizeTablero = 20;
            tablero.ColumnCount = sizeTablero+1;
            tablero.RowCount = sizeTablero+1;      //Agrega uno para los indices
            for (int i = 1; i <= sizeTablero; i++)
                for (int j = 1; j <= sizeTablero; j++)
                    tablero[j, i].Value = ""; // Limpia las celdas
            tablero.RowHeadersWidth = 25;
            tablero.ColumnHeadersHeight = 25;     // Fija dimensiones de los indices
            for (int i = 1; i <= sizeTablero; i++)
            {
                tablero[0, i].Value = i;
                tablero[i, 0].Value = i;  //Escribe índices
                tablero.Columns[i].Width = 20;   // Fija dimensiones de las celdas
                tablero.Rows[i].Height = 20;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a.empezar();
           
        }

        private void tablero_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (radioButtonInicio.Checked)
            {
                this.tablero.CurrentCell.Style.BackColor = Color.Red;
                a.inicio.X = tablero.CurrentCell.ColumnIndex;
                a.inicio.Y = tablero.CurrentCell.RowIndex;
                labelInicio.Text = "(" + a.inicio.X + "," + a.inicio.Y + ")";

            }
            if (radioButtonMeta.Checked)
            {
                this.tablero.CurrentCell.Style.BackColor = Color.Green;
                a.meta.X = tablero.CurrentCell.ColumnIndex;
                a.meta.Y = tablero.CurrentCell.RowIndex;
                labelMeta.Text = "(" + a.meta.X + "," + a.meta.Y + ")";
            }
            if (radioButtonObstaculo.Checked)
                     this.tablero.CurrentCell.Style.BackColor = Color.Aqua;
            if (radioButtonNinguno.Checked)
            {             
                this.tablero.CurrentCell.Style.BackColor = Color.White;
            }

            int j = tablero.CurrentCell.ColumnIndex;
            int i = tablero.CurrentCell.RowIndex;
            label5.Text = "Celda(" + j.ToString() + "," + i.ToString() + ")";
            //label4.Text = "h(n)="+a.h[j, i].ToString("F2");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

		private void radioButtonObstaculo_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
            tablero.BackgroundColor = Color.White;
		}
	}
}
