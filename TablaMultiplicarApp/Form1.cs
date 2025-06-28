using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablaMultiplicarApp 
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
        
            lstTabla.Items.Clear();

           
            string textoNumero = txtNumero.Text;

           
            int numero;
            bool esNumeroValido = int.TryParse(textoNumero, out numero);

            if (!esNumeroValido)
            {
                MessageBox.Show("Por favor, ingresa un número entero válido.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Focus(); 
                return; 
            }

            
            if (numero < 1 || numero > 100) 
            {
                MessageBox.Show("Por favor, ingresa un número entre 1 y 100.", "Número Fuera de Rango", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
                return;
            }

            
            for (int i = 1; i <= 10; i++) 
            {
                int resultado = numero * i;

                lstTabla.Items.Add($"{numero} x {i} = {resultado}");
            }
        }

        
        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }
    }
}
