using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PImc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            double peso, altura, imc;
            try
            {
                peso = Convert.ToDouble(txtPeso1.Text);
                altura = Convert.ToDouble(txtAltura1.Text);
                imc = peso / (altura * altura);
                imc = Math.Round(imc, 1);

                if (imc < 18.5)
                    txtImc.Text = "Magreza\nSeu IMC:" + imc;

                else if (imc >= 18.5 && imc < 24.9)
                    txtImc.Text = "Peso normal\nSeu IMC:" + imc;

                else if (imc >= 25 && imc < 29.9)
                    txtImc.Text = "Sobre peso\nSeu IMC:" + imc;

                else if (imc >= 30 && imc < 39.9)
                    txtImc.Text = "Obeso\nSeu IMC:" + imc;

                else txtImc.Text = "Obeso MórbidonSeu IMC:" + imc;
            }
            catch { MessageBox.Show("Dados invalidos"); }

        }

        private void Calcular(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAltura1.Text = "";
            txtPeso1.Text = "";
            txtImc.Text = "";

            txtAltura1.Focus();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

