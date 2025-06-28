using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroPerfectoApp 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            
            string textoNumero = mtxtNumero.Text.Trim();


            if (string.IsNullOrWhiteSpace(textoNumero))
            {
                MessageBox.Show("Por favor, ingresa un número.", "Entrada Vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtNumero.Focus(); 
                return; 
            }


            long numero;
            bool esNumeroValido = long.TryParse(textoNumero, out numero);

            if (!esNumeroValido)
            {

                MessageBox.Show("Entrada inválida. Por favor, ingresa un número entero positivo.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtxtNumero.Focus();
                return;
            }


            if (numero <= 0)
            {
                MessageBox.Show($"El número {numero} no puede ser un número perfecto. Los números perfectos son enteros positivos.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtxtNumero.Clear(); 
                mtxtNumero.Focus(); 
                return;
            }


            bool esPerfecto = EsNumeroPerfecto(numero);

           
            if (esPerfecto)
            {
                MessageBox.Show($"El número {numero} ES un número perfecto.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"El número {numero} NO es un número perfecto.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            mtxtNumero.Clear(); 
            mtxtNumero.Focus(); 
        }


        /// <param name="num">.</param>

        private bool EsNumeroPerfecto(long num)
        {

            if (num == 1)
                return false;

            long sumaDivisores = 1; 

            
            
            for (long i = 2; i * i <= num; i++)
            {
                if (num % i == 0) 
                {
                    sumaDivisores += i; 
                    if (i * i != num) 
                    {
                        sumaDivisores += (num / i); 
                    }
                }
            }

          
            return sumaDivisores == num;
        }

       
        private void mtxtNumero_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
