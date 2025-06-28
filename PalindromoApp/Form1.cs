using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalindromoApp 
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
           
            string palabraOriginal = txtPalabra.Text;

           
            if (string.IsNullOrWhiteSpace(palabraOriginal))
            {
                MessageBox.Show("Por favor, ingresa una palabra antes de verificar.", "Entrada Vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPalabra.Focus(); 
                return; 
            }

           
            string palabraLimpia = palabraOriginal.ToLower().Replace(" ", "");

           
            char[] arrayCaracteres = palabraLimpia.ToCharArray();
            Array.Reverse(arrayCaracteres);
            string palabraInvertida = new string(arrayCaracteres);


            if (palabraLimpia == palabraInvertida)
            {
                MessageBox.Show($"'{palabraOriginal}' ES un palíndromo.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"'{palabraOriginal}' NO es un palíndromo.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtPalabra.Clear(); 
            txtPalabra.Focus(); 
        }

       
        private void txtPalabra_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
