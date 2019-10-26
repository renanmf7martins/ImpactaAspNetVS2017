using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpactaAspNet.Capitulo01.Troco
{
    public partial class TrocoForm : Form
    {
        public TrocoForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            decimal valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);
            decimal valorPago = Convert.ToDecimal(valorPagoTextBox.Text);

            decimal troco = valorPago - valorCompra;

            trocoTextBox.Text = troco.ToString("C2");

            int[] moedasResultado = new int[6];
            decimal[] moedas = new decimal[]
            {
                1,
                0.5m,
                0.25m,
                0.1m,
                0.05m,
                0.01m
            };

            //ToDo: Teste
            for (int i = 0; i < 6; ++i)
            {
                moedasResultado[i] = (int)(troco / moedas[i]);
                troco %= moedas[i];
                moedasListView.Items[i].Text = moedasResultado[i].ToString();
            }





            //int quantMoedas1Real = (int)troco / 1;
            //troco %= 1;

            //int quantMoedas50Centavos = (int)(troco / 0.50m);
            //troco %= 0.5m;

            //int quantMoedas25Centavos = (int)(troco / 0.25m);
            //troco %= 0.25m;

            //int quantMoedas10Centavos = (int)(troco / 0.10m);
            //troco %= 0.10m;

            //int quantMoedas5Centavos = (int)(troco / 0.05m);
            //troco %= 0.05m;

            //int quantMoedas1Centavos = (int)(troco / 0.01m);
            //troco %= 0.01m;
        }

    }
}
