using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace CalculadoraV2._0
{
    //em desenvolvimento
    //em desenvolvimento
    //em desenvolvimento
    //em desenvolvimento
    //em desenvolvimento
    //em desenvolvimento
    //em desenvolvimento
    public partial class frmCalculadora : Form
    {
        Variaveis var = new Variaveis();
        public frmCalculadora()
        {
            InitializeComponent();
            txtResultado.Focus();
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Focus();
            txtResultado.Text += "0";
            txtCalculo.Text += "0";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Focus();
            txtResultado.Text += "1";
            txtCalculo.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Focus();
            txtResultado.Text += "2";
            txtCalculo.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Focus();
            txtResultado.Text += "3";
            txtCalculo.Text += "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Focus();
            txtResultado.Text += "4";
            txtCalculo.Text += "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Focus();
            txtResultado.Text += "5";
            txtCalculo.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Focus();
            txtResultado.Text += "6";
            txtCalculo.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Focus();
            txtResultado.Text += "7";
            txtCalculo.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Focus();
            txtResultado.Text += "8";
            txtCalculo.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Focus();
            txtResultado.Text += "9";
            txtCalculo.Text += "9";
        }
        private void btnSoma_Click(object sender, EventArgs e)
        {
            txtResultado.Focus();
            var.calculo = decimal.Parse(txtResultado.Text);
            txtCalculo.Text += "+";
            txtResultado.Text = "";
            var.adicao = true;
            var.subtracao = false;
            var.multiplicacao = false;
            var.divisao = false;
        }
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txtResultado.Focus();
            if (!txtResultado.Text.Contains(","))
            {
                txtResultado.Text += ",";
                txtCalculo.Text += ",";
            }
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            txtResultado.Focus();
            var.resultado = true;
            txtCalculo.Text += "=";
            if (var.adicao == true)
            {
                txtResultado.Text = Convert.ToString(decimal.Parse(txtResultado.Text) + var.calculo);
                txtCalculo.Text += txtResultado.Text;
            }
            if (var.subtracao == true)
            {
                txtResultado.Text = Convert.ToString(var.calculo - decimal.Parse(txtResultado.Text));
                txtCalculo.Text += txtResultado.Text;
            }
            if (var.multiplicacao == true)
            {
                txtResultado.Text = Convert.ToString(var.calculo * decimal.Parse(txtResultado.Text));
                txtCalculo.Text += txtResultado.Text;
            }
            if (var.divisao == true)
            {
                txtResultado.Text = Convert.ToString(var.calculo / decimal.Parse(txtResultado.Text));
                txtCalculo.Text += txtResultado.Text;
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Focus();
            txtResultado.Text = "";
            txtCalculo.Text = "";
        }
        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            txtResultado.Focus();
            var.calculo = decimal.Parse(txtResultado.Text);
            txtCalculo.Text += "-";
            txtResultado.Text = "";
            var.adicao = false;
            var.subtracao = true;
            var.multiplicacao = false;
            var.divisao = false;
        }
        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            txtResultado.Focus();
            var.calculo = decimal.Parse(txtResultado.Text);
            txtCalculo.Text += "x";
            txtResultado.Text = "";
            var.adicao = false;
            var.subtracao = false;
            var.multiplicacao = true;
            var.divisao = false;
        }
        private void btnDivisao_Click(object sender, EventArgs e)
        {
            txtResultado.Focus();
            var.calculo = decimal.Parse(txtResultado.Text);
            txtCalculo.Text += "/";
            txtResultado.Text = "";
            var.adicao = false;
            var.subtracao = false;
            var.multiplicacao = false;
            var.divisao = true;
        }
        private void btnApagaUltimoNm_Click(object sender, EventArgs e)
        {
            txtResultado.Focus();
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
                txtCalculo.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "";
            }
        }
        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            txtResultado.Focus();
            if (var.adicao == true)
            {
                double valor1 = Convert.ToDouble(var.calculo);
                double percentual = Convert.ToDouble(txtResultado.Text) / 100;
                txtResultado.Text = Convert.ToString(valor1 + (percentual * valor1));
                txtCalculo.Text += "% =";
                txtCalculo.Text += txtResultado.Text;
            }
            if (var.subtracao == true)
            {
                double valor1 = Convert.ToDouble(var.calculo);
                double percentual = Convert.ToDouble(txtResultado.Text) / 100;
                txtResultado.Text = Convert.ToString(valor1 - (percentual * valor1));
                txtCalculo.Text += "% =";
                txtCalculo.Text += txtResultado.Text;
            }            
        }
        private void btnRaizQuadrada_Click(object sender, EventArgs e)
        {
            txtResultado.Focus();
            try
            {
                double numero1 = Convert.ToDouble(txtResultado.Text);
                if (numero1 < 0)
                {
                    MessageBox.Show("Valor inválido");
                }
                else
                {
                    numero1 = Math.Sqrt(numero1);
                    txtResultado.Text = numero1.ToString();
                    txtCalculo.Text += "√ =";
                    txtCalculo.Text += numero1.ToString();
                }
            }
            catch (Exception) { }            
        }
        private void txtResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == 'x' || e.KeyChar == '/')
            {
                txtResultado.Text += e.KeyChar;
                e.Handled = true;
            }
        }
    }
}
