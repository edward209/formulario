using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperE
{
    public partial class Form1 : Form
    {
        private Dictionary<char, int[,]> mapaNumeros;



        public Form1()
        {
            InitializeComponent();
        }

        private void InicializarMapas()
        {
            mapaNumeros = new Dictionary<char, int[,]>
    {
        { '0', new int[,] {
            {1,1,1,1,1},
            {1,0,0,0,1},
            {1,0,0,1,1},
            {1,0,1,0,1},
            {1,1,0,0,1},
            {1,0,0,0,1},
            {1,1,1,1,1}
        }},
        { '1', new int[,] {
            {0,0,1,0,0},
            {0,1,1,0,0},
            {1,0,1,0,0},
            {0,0,1,0,0},
            {0,0,1,0,0},
            {0,0,1,0,0},
            {1,1,1,1,1}
        }},
        { '2', new int[,] {
            {1,1,1,1,1},
            {0,0,0,0,1},
            {0,0,0,1,1},
            {0,0,1,1,0},
            {0,1,1,0,0},
            {1,1,0,0,0},
            {1,1,1,1,1}
        }},
        { '3', new int[,] {
            {1,1,1,1,1},
            {0,0,0,0,1},
            {0,0,1,1,1},
            {0,0,0,0,1},
            {0,0,0,0,1},
            {1,0,0,0,1},
            {1,1,1,1,1}
        }},
        { '4', new int[,] {
            {1,0,0,1,0},
            {1,0,0,1,0},
            {1,0,0,1,0},
            {1,1,1,1,1},
            {0,0,0,1,0},
            {0,0,0,1,0},
            {0,0,0,1,0}
        }},
        { '5', new int[,] {
            {1,1,1,1,1},
            {1,0,0,0,0},
            {1,1,1,1,0},
            {0,0,0,0,1},
            {0,0,0,0,1},
            {1,0,0,0,1},
            {0,1,1,1,0}
        }},
        { '6', new int[,] {
            {0,1,1,1,0},
            {1,0,0,0,0},
            {1,0,0,0,0},
            {1,1,1,1,0},
            {1,0,0,0,1},
            {1,0,0,0,1},
            {0,1,1,1,0}
        }},
        { '7', new int[,] {
            {1,1,1,1,1},
            {0,0,0,0,1},
            {0,0,0,1,0},
            {0,0,1,0,0},
            {0,1,0,0,0},
            {0,1,0,0,0},
            {0,1,0,0,0}
        }},
        { '8', new int[,] {
            {0,1,1,1,0},
            {1,0,0,0,1},
            {1,0,0,0,1},
            {0,1,1,1,0},
            {1,0,0,0,1},
            {1,0,0,0,1},
            {0,1,1,1,0}
        }},
        { '9', new int[,] {
            {0,1,1,1,0},
            {1,0,0,0,1},
            {1,0,0,0,1},
            {0,1,1,1,1},
            {0,0,0,0,1},
            {0,0,0,0,1},
            {0,1,1,1,0}
        }},
    };
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            string texto = textBox1.Text.Trim();
            if (texto.Length > 4) texto = texto.Substring(0, 4);

            int anchoBloque = 20;
            int altoBloque = 20;
            int espacioEntreNumeros = 10;

            for (int i = 0; i < texto.Length; i++)
            {
                char digito = texto[i];
                if (!mapaNumeros.ContainsKey(digito)) continue;

                int[,] matriz = mapaNumeros[digito];

                for (int fila = 0; fila < 7; fila++)
                {
                    for (int col = 0; col < 5; col++)
                    {
                        Panel bloque = new Panel();
                        bloque.Width = anchoBloque;
                        bloque.Height = altoBloque;
                        bloque.BackColor = (matriz[fila, col] == 1) ? Color.Black : Color.White;
                        bloque.BorderStyle = BorderStyle.FixedSingle;
                        bloque.Location = new Point(
                            i * (5 * anchoBloque + espacioEntreNumeros) + col * anchoBloque,
                            fila * altoBloque
                        );
                        panel1.Controls.Add(bloque);
                    }
                }
            }
        }

        

        }
    }

