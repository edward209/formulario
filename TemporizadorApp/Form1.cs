using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemporizadorApp 
{
    public partial class Form1 : Form
    {
        private int segundosTotales;    
        private int segundosRestantes;  

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.StartPosition = FormStartPosition.CenterScreen;



            lblTiempoRestante.Text = "00:00";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            int minutosInput;
            int segundosInput;


            if (!int.TryParse(txtMinutos.Text, out minutosInput) || minutosInput < 0)
            {
                MessageBox.Show("Por favor, ingresa un valor válido para minutos (número entero no negativo).", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMinutos.Focus(); 
                return; 
            }


            if (!int.TryParse(txtSegundos.Text, out segundosInput) || segundosInput < 0 || segundosInput >= 60)
            {
                MessageBox.Show("Por favor, ingresa un valor válido para segundos (número entero entre 0 y 59).", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSegundos.Focus(); 
                return; 
            }


            segundosTotales = (minutosInput * 60) + segundosInput;


            if (segundosTotales <= 0)
            {
                MessageBox.Show("El tiempo total configurado debe ser mayor a cero.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMinutos.Focus(); 
                return; 
            }


            segundosRestantes = segundosTotales;


            ActualizarTiempoRestanteUI();


            txtMinutos.Enabled = false; 
            txtSegundos.Enabled = false; 
            btnIniciar.Enabled = false;  
            btnDetener.Enabled = true;   


            cronometro.Start();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            cronometro.Stop(); 

            
            txtMinutos.Enabled = true;   
            txtSegundos.Enabled = true;  
            btnIniciar.Enabled = true;   
            btnDetener.Enabled = false;  

            lblTiempoRestante.Text = "00:00"; 

            
            
            
        }

        
        private void cronometro_Tick(object sender, EventArgs e)
        {
            segundosRestantes--; 


            ActualizarTiempoRestanteUI();

         
            if (segundosRestantes <= 0)
            {
                cronometro.Stop(); 

                
                txtMinutos.Enabled = true;
                txtSegundos.Enabled = true;
                btnIniciar.Enabled = true;
                btnDetener.Enabled = false;
                lblTiempoRestante.Text = "00:00"; 

         
                MessageBox.Show("¡Tiempo agotado!", "Temporizador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void ActualizarTiempoRestanteUI()
        {

            int minutos = segundosRestantes / 60;

            int segundos = segundosRestantes % 60;


            lblTiempoRestante.Text = $"{minutos:D2}:{segundos:D2}";
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
