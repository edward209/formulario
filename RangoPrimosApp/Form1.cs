using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RangoPrimosApp 
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

        private void btnBuscarPrimos_Click(object sender, EventArgs e)
        {
   
            lstPrimos.Items.Clear();


            string textoInicio = txtInicio.Text.Trim();
            string textoFin = txtFin.Text.Trim();

            int inicioRango;
            int finRango;


            if (!int.TryParse(textoInicio, out inicioRango) || inicioRango < 0)
            {
                MessageBox.Show("Por favor, ingresa un número válido y no negativo para el inicio del rango.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInicio.Focus();
                return;
            }

 
            if (!int.TryParse(textoFin, out finRango) || finRango < 0)
            {
                MessageBox.Show("Por favor, ingresa un número válido y no negativo para el fin del rango.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFin.Focus();
                return;
            }


            if (inicioRango > finRango)
            {
                MessageBox.Show("El valor de inicio del rango no puede ser mayor que el valor de fin.", "Error de Rango", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInicio.Focus();
                return;
            }


            for (int i = inicioRango; i <= finRango; i++)
            {
                if (EsNumeroPrimo(i))
                {
                    lstPrimos.Items.Add(i); 
                }
            }


            if (lstPrimos.Items.Count == 0)
            {
                MessageBox.Show($"No se encontraron números primos en el rango de {inicioRango} a {finRango}.", "Sin Primos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <param name="num"

        private bool EsNumeroPrimo(int num)
        {
            if (num <= 1)
                return false;


            if (num == 2)
                return true;


            if (num % 2 == 0)
                return false;


            for (int i = 3; i * i <= num; i += 2)
            {
                if (num % i == 0)
                    return false; 
            }

            return true; 
        }


        private void txtInicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFin_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstPrimos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
