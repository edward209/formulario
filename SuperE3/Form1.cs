using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperE3
{
    public partial class Form1 : Form
    {
        private Dictionary<char, int[,]> mapaNumeros;
        private string numeroActual = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarMapaNumeros();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            numeroActual = textBox1.Text;
            panel1.Invalidate(); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int size = 20;
            int espacio = 10;
            int xInicio = 10;

            foreach (char c in numeroActual)
            {
                if (mapaNumeros.ContainsKey(c))
                {
                    var matriz = mapaNumeros[c];
                    for (int fila = 0; fila < matriz.GetLength(0); fila++)
                    {
                        for (int col = 0; col < matriz.GetLength(1); col++)
                        {
                            if (matriz[fila, col] == 1)
                            {
                                e.Graphics.FillRectangle(
                                    Brushes.Red,
                                    xInicio + col * size,
                                    fila * size,
                                    size - 2,
                                    size - 2);
                            }
                        }
                    }
                    xInicio += (matriz.GetLength(1) * size) + espacio;
                }
            }
        }

        private void InicializarMapaNumeros()
        {
            mapaNumeros = new Dictionary<char, int[,]>
            {
                { '0', new int[,] {
                    {1,1,1},
                    {1,0,1},
                    {1,0,1},
                    {1,0,1},
                    {1,1,1} } },

                { '1', new int[,] {
                    {0,1,0},
                    {1,1,0},
                    {0,1,0},
                    {0,1,0},
                    {1,1,1} } },

                { '2', new int[,] {
                    {1,1,1},
                    {0,0,1},
                    {1,1,1},
                    {1,0,0},
                    {1,1,1} } },

                { '3', new int[,] {
                    {1,1,1},
                    {0,0,1},
                    {0,1,1},
                    {0,0,1},
                    {1,1,1} } },

                { '4', new int[,] {
                    {1,0,1},
                    {1,0,1},
                    {1,1,1},
                    {0,0,1},
                    {0,0,1} } },

                { '5', new int[,] {
                    {1,1,1},
                    {1,0,0},
                    {1,1,1},
                    {0,0,1},
                    {1,1,1} } },

                { '6', new int[,] {
                    {1,1,1},
                    {1,0,0},
                    {1,1,1},
                    {1,0,1},
                    {1,1,1} } },

                { '7', new int[,] {
                    {1,1,1},
                    {0,0,1},
                    {0,1,0},
                    {0,1,0},
                    {0,1,0} } },

                { '8', new int[,] {
                    {1,1,1},
                    {1,0,1},
                    {1,1,1},
                    {1,0,1},
                    {1,1,1} } },

                { '9', new int[,] {
                    {1,1,1},
                    {1,0,1},
                    {1,1,1},
                    {0,0,1},
                    {1,1,1} } }
            };
        }
    }
}

