using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CalculadoraEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal valor1, valor2;
        string operacao;

        private void btnzero_Click(object sender, EventArgs e)
        {
            txtvalores.Text += "0";
        }

        private void btnum_Click(object sender, EventArgs e)
        {
            txtvalores.Text += "1";
        }

        private void btndois_Click(object sender, EventArgs e)
        {
            txtvalores.Text += "2";
        }

        private void btntres_Click(object sender, EventArgs e)
        {
            txtvalores.Text += "3";
        }

        private void btnquatro_Click(object sender, EventArgs e)
        {
            txtvalores.Text += "4";
        }

        private void btncinco_Click(object sender, EventArgs e)
        {
            txtvalores.Text += "5";
        }

        private void btnseis_Click(object sender, EventArgs e)
        {
            txtvalores.Text += "6";
        }

        private void btnsete_Click(object sender, EventArgs e)
        {
            txtvalores.Text += "7";
        }

        private void btnoito_Click(object sender, EventArgs e)
        {
            txtvalores.Text += "8";
        }

        private void btnnove_Click(object sender, EventArgs e)
        {
            txtvalores.Text += "9";
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtvalores.Text, CultureInfo.InvariantCulture);
            txtvalores.Text = "";
            operacao = "SOMA";
            lbloperacao.Text = "+";
            
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtvalores.Text, CultureInfo.InvariantCulture);
            txtvalores.Text = "";
            operacao = "SUBTRACAO";
            lbloperacao.Text = "-";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtvalores.Text, CultureInfo.InvariantCulture);
            txtvalores.Text = "";
            operacao = "DIVISAO";
            lbloperacao.Text = "/";
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtvalores.Text, CultureInfo.InvariantCulture);
            txtvalores.Text = "";
            operacao = "MULTIPLICACAO";
            lbloperacao.Text = "*";
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtvalores.Text, CultureInfo.InvariantCulture);

            if(operacao == "SOMA")
            {
                txtvalores.Text = Convert.ToString(valor1 + valor2);
            }

            if(operacao == "SUBTRACAO")
            {
                txtvalores.Text = Convert.ToString(valor1 - valor2);
            }
            
            if(operacao == "DIVISAO")
            {
                txtvalores.Text = Convert.ToString(valor1 / valor2);
            }
            if(operacao == "MULTIPLICACAO")
            {
                txtvalores.Text = Convert.ToString(valor1 * valor2);
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtvalores.Text = string.Empty;
            lbloperacao.Text = string.Empty;
        }

        
    }
}
