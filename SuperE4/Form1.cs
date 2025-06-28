using System;
using System.Collections.Generic;
using System.Drawing; 
using System.Windows.Forms; 

namespace SuperE4
{
    public partial class Form1 : Form
    {
        private Panel[,,] paneles = new Panel[4, 5, 4]; 
        private Dictionary<int[,], char> mapaInverso;
        private const int panelSize = 30; 

        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CrearPaneles(); 
            InicializarMapas(); 
        }

        private void CrearPaneles()
        {

            for (int digito = 0; digito < 4; digito++)
            {
  
                for (int fila = 0; fila < 5; fila++)
                {

                    for (int col = 0; col < 4; col++)
                    {
                        Panel p = new Panel(); 
                        p.Size = new Size(panelSize, panelSize); 
                        p.BackColor = Color.White; 
                        p.BorderStyle = BorderStyle.FixedSingle; 


                        int x = 10 + digito * (4 * (panelSize + 2) + 20) + col * (panelSize + 2);
                        int y = 10 + fila * (panelSize + 2);
                        p.Location = new Point(x, y);

                        p.Tag = (digito, fila, col); 
                        p.Click += Panel_Click; 

                        this.Controls.Add(p); 
                        paneles[digito, fila, col] = p; 
                    }
                }
            }
        }

      
        private void Panel_Click(object sender, EventArgs e)
        {
            Panel p = sender as Panel; 
            if (p.BackColor == Color.Red)
            {
                p.BackColor = Color.White; 
            }
            else
            {
                p.BackColor = Color.Red; 
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string resultado = ""; 

 
            for (int digito = 0; digito < 4; digito++)
            {
                int[,] entrada = new int[5, 4]; 

            
                for (int fila = 0; fila < 5; fila++)
                {
                    for (int col = 0; col < 4; col++)
                    {
                        entrada[fila, col] = paneles[digito, fila, col].BackColor == Color.Red ? 1 : 0;
                    }
                }


                char? numero = ReconocerNumero(entrada);
      
                resultado += numero?.ToString() ?? "?";
            }


            textBox1.Text = resultado;
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            for (int digito = 0; digito < 4; digito++)
            {
                for (int fila = 0; fila < 5; fila++)
                {
                    for (int col = 0; col < 4; col++)
                    {
                        paneles[digito, fila, col].BackColor = Color.White;
                    }
                }
            }

            textBox1.Clear(); 
        }


        private char? ReconocerNumero(int[,] matrizEntrada)
        {

            foreach (var kvp in mapaInverso)
            {

                if (MatricesIguales(kvp.Key, matrizEntrada))
                {
                    return kvp.Value; 
                }
            }
            return null; 
        }


        private bool MatricesIguales(int[,] a, int[,] b)
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 4; j++)
                    if (a[i, j] != b[i, j])
                        return false; 
            return true; 
        }


        private void InicializarMapas()
        {
            
            mapaInverso = new Dictionary<int[,], char>(new MatrizComparer())
            {
               
                { new int[,] {
                    {1,1,1,1},
                    {1,0,0,1},
                    {1,0,0,1},
                    {1,0,0,1},
                    {1,1,1,1}
                }, '0' },

              
                { new int[,] {
                    {0,1,0,0},
                    {1,1,0,0},
                    {0,1,0,0},
                    {0,1,0,0},
                    {1,1,1,0}
                }, '1' },

               
                { new int[,] {
                    {1,1,1,0},
                    {0,0,0,1},
                    {1,1,1,0},
                    {1,0,0,0},
                    {1,1,1,1}
                }, '2' },

                
                { new int[,] {
                    {1,1,1,0},
                    {0,0,0,1},
                    {0,1,1,0},
                    {0,0,0,1},
                    {1,1,1,0}
                }, '3' },
               
                { new int[,] {
                    {1,0,0,1},
                    {1,0,0,1},
                    {1,1,1,1},
                    {0,0,0,1},
                    {0,0,0,1}
                }, '4' },
                 
                { new int[,] {
                    {1,1,1,1},
                    {1,0,0,0},
                    {1,1,1,0},
                    {0,0,0,1},
                    {1,1,1,0}
                }, '5' },
                
                { new int[,] {
                    {0,1,1,1},
                    {1,0,0,0},
                    {1,1,1,0},
                    {1,0,0,1},
                    {0,1,1,0}
                }, '6' },
                
                { new int[,] {
                    {1,1,1,1},
                    {0,0,0,1},
                    {0,0,1,0},
                    {0,1,0,0},
                    {1,0,0,0}
                }, '7' },
                
                { new int[,] {
                    {0,1,1,0},
                    {1,0,0,1},
                    {0,1,1,0},
                    {1,0,0,1},
                    {0,1,1,0}
                }, '8' },
                
                { new int[,] {
                    {0,1,1,0},
                    {1,0,0,1},
                    {0,1,1,1},
                    {0,0,0,1},
                    {0,1,1,0}
                }, '9' }
            };
        }

        
        class MatrizComparer : IEqualityComparer<int[,]>
        {
            public bool Equals(int[,] a, int[,] b)
            {
               
                if (a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1))
                    return false;

                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] != b[i, j])
                            return false; 
                return true; 
            }

            public int GetHashCode(int[,] obj)
            {
                int hash = 17; 
                foreach (var item in obj)
                    hash = hash * 31 + item.GetHashCode(); 
                return hash;
            }
        }
    }
}
