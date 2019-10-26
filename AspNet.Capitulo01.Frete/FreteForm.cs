using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNet.Capitulo01.Frete
{
    public partial class FreteForm : Form
    {
        public FreteForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            var erros = ValidarFormulario();

            if (erros.Count == 0)
            {
                Calcular();
            }
            else
            {
                string mensagem = "";
                erros.ForEach(h =>
                {
                    mensagem += h + "\n";
                });

                MessageBox.Show(
                    mensagem, 
                    "Aviso", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }
        }

        

        private void Calcular()
        {
            var percentual = 0m;

            var valor = Convert.ToDecimal(valorTextBox.Text);
            var nordeste = new List<string>()
            {
                "BA",
                "AL",
                "CE"
            };

            switch (ufComboBox.Text.ToUpper())
            {
                case "SP":
                    percentual = 0.2m;
                    break;
                case "MG":
                    percentual = 0.3m;
                    break;
                case "RJ":
                    percentual = 0.35m;
                    break;
                case "AM":
                    percentual = 0.6m;
                    break;
                case var uf when nordeste.Contains(uf):
                    percentual = 0.8m;
                    break;
                default:
                    percentual = 0.7m;
                    break;
            }

            decimal valorConvertido = Convert.ToDecimal(valorTextBox.Text);

            freteTextBox.Text = percentual.ToString("p2");
            totalTextBox.Text = (valorConvertido * (percentual + 1)).ToString("c"); 

        }

        private List<string> ValidarFormulario()
        {
            List<string> erros = new List<string>();

            if (clienteTextBox.Text.Trim() == string.Empty)
            {
                erros.Add("O nome do cliente não pode ser vazio!!!");
            }

            if (valorTextBox.Text.Trim() == string.Empty)
            {
                erros.Add("O valor deve ser preenchido!!!");
            }
            else
            {
                if (!decimal.TryParse(valorTextBox.Text.Trim(), out decimal resultado))
                {
                    erros.Add("O campo valor deve ser numérico!!!");
                }
            }

            if (ufComboBox.SelectedIndex == -1)
            {
                erros.Add("Por favor selecione alguma cidade!!!");
            }

            return erros;
        }

        private void limparButton_Click(object sender, EventArgs e) {
            clienteTextBox.Clear();
            valorTextBox.Clear();
            ufComboBox.SelectedIndex = -1;
            freteTextBox.Clear();
            totalTextBox.Clear();
        }
    }
}
