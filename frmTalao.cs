using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talao
{
    public partial class frmTalao : Form
    {
        public frmTalao()
        {
            InitializeComponent();
        }

        //Criar Vetor de Produtos a exibir na comboBox
        string[] produtos = new string[8];
        //Criar Vetor de Preços a exibir na maskedTextBox
        int[] precos = new int[8];
        
        // criar string auxiliar para escrever o cabeçalho no talão
        string talao = String.Format("{0,-25} {1,15} {2,30} {3,30}",
                        "Produto", "Quant", "Preço", "Total") + Environment.NewLine;

        // Criar variavel para saber o valor a pagar
        int pagar =0;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Preencher os vários indices de produtos e precos
            //prestar atenção aos indices. Existe uma relação entre os indices.
            //O indice 0 de produtos corresponde ao Rato 
            //O indice 0 de precos corresponde ao Preço do Rato
            
            produtos[0] = "Rato";
            precos[0] = 45;
            
            produtos[1] = "Teclado";
            precos[1] = 30;
            
            produtos[2] = "Auriculares";
            precos[2] = 180;
            
            produtos[3] = "Monitor";
            precos[3] = 140;
            
            produtos[4] = "Tablet";
            precos[4] = 540;
            
            produtos[5] = "Portátil";
            precos[5] = 1000;
            
            produtos[6] = "Surface";
            precos[6] = 1120;
            
            produtos[7] = "MacBook";
            precos[7] = 1700;

            foreach(string s in produtos)
            {
                comboBoxProduto.Items.Add(s);
            }

        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            // C -> currency (moeda) 0:C2 -> moeda com 2 casas decimais
            maskedTextBoxPreco.Text = String.Format("{0:C2}", precos[comboBoxProduto.SelectedIndex]);
            
            //Calcular o total por linha e mostrá-lo
            textBoxTotal.Text = String.Format("{0:C2}", numericUpDownQtd.Value * precos[comboBoxProduto.SelectedIndex]);
        }

        private void numericUpDownQtd_ValueChanged(object sender, EventArgs e)
        {
            //ReCalcular o total por linha e mostrá-lo
            textBoxTotal.Text = String.Format("{0:C2}", numericUpDownQtd.Value * precos[comboBoxProduto.SelectedIndex]);
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            //adicionar à variavel pagar o valor do total
            pagar += (Convert.ToInt32(numericUpDownQtd.Value) * precos[comboBoxProduto.SelectedIndex]);

            //preparar o texto a ser impresso
            talao += String.Format("{0,-25} {1,15} {2,30} {3,30}", 
                                comboBoxProduto.Text, 
                                Convert.ToString(numericUpDownQtd.Value), 
                                maskedTextBoxPreco.Text, 
                                textBoxTotal.Text) + Environment.NewLine;

            //mostrar no talão o registo
            textBoxTalao.Text = talao;

            //mostrar o valor total a pagar
            textBoxPagar.Text = String.Format("{0:C2}",pagar);
        }

    }
}
