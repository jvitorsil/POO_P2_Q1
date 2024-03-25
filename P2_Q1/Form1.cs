using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P2_Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.caminhao;
            gerarGradeListView();

        }
        public void gerarGradeListView()
        {
            listView1.Columns.Add("Placa", 70).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Ano", 70).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Assentos", 70).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Eixos", 70).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Diaria", 70).TextAlign = HorizontalAlignment.Center;
            listView1.View = View.Details;
        }
        public bool validaInformacao()
        {

            bool validaInfo = true;

            if (mtbPlaca.MaskCompleted == false)
            {
                MensagemBotao(label1.Text);
                validaInfo = false;
            }
            else if (maskedTextBox2.Text.Trim() == string.Empty) 
            {
                MensagemBotao(label2.Text);
                validaInfo = false;
            }
            else if (maskedTextBox3.Text.Trim() == string.Empty)
            {
                MensagemBotao(label3.Text);
                validaInfo = false;
            }

            return validaInfo;
        }

        private void MensagemBotaoSucess(string valorAluguel)
        {
            MessageBox.Show("Cotação realizada com sucesso, o valor da diaria é de " + valorAluguel +"!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensagemBotao(string nomelabel)
        {
            MessageBox.Show("Voce deve Informar o " + nomelabel + "!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mtbPlaca.Mask = "LLL-0000"; 

            label1.Text = "Placa";
            label2.Text = "Ano";
            label3.Text = "Qtd Eixos";
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbPlaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbAno_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbAssentosEixo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lvAluguel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            bool recebeValidacao = validaInformacao();
            if (radioButton1.Checked == true && recebeValidacao == true)
            {
                Onibus onibus = new Onibus(mtbPlaca.Text, Convert.ToInt32(maskedTextBox2.Text), Convert.ToInt32(maskedTextBox3.Text));

                string[] onibusLV = new string[5];
                onibusLV[0] = onibus.Placa;
                onibusLV[1] = Convert.ToString(onibus.Ano);
                onibusLV[2] = Convert.ToString(onibus.Assentos);
                onibusLV[3] = Convert.ToString(" ");
                onibusLV[4] = "R$" + Convert.ToString(onibus.CalcAluguel());

                listView1.Items.Add(new ListViewItem(onibusLV));

                MensagemBotaoSucess(onibusLV[4]);
                Limpar();
            }
            else if (radioButton2.Checked == true && recebeValidacao == true)
            {
                Caminhao caminhao = new Caminhao(mtbPlaca.Text, Convert.ToInt32(maskedTextBox2.Text), Convert.ToInt32(maskedTextBox3.Text));


                string[] caminhaoLV = new string[6];

                caminhaoLV[0] = caminhao.Placa;
                caminhaoLV[1] = Convert.ToString(caminhao.Ano);
                caminhaoLV[2] = Convert.ToString(" ");
                caminhaoLV[3] = Convert.ToString(caminhao.Eixos);
                caminhaoLV[4] = "R$" + Convert.ToString(caminhao.CalcAluguel());

                listView1.Items.Add(new ListViewItem(caminhaoLV));

                MensagemBotaoSucess(caminhaoLV[4]);
                Limpar();
            }
        }

        private void Limpar()
        {
            mtbPlaca.Text = string.Empty;
            maskedTextBox2.Text = string.Empty;
            maskedTextBox3.Text = string.Empty;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mtbPlaca.Mask = "LLL-0000"; 

            label1.Text = "Placa";
            label2.Text = "Ano";
            label3.Text = "Qtd Assentos";
        }


    }
}
