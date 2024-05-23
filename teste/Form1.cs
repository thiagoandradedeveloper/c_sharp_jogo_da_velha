using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class Form1 : Form
    {

        string vez_jogador = "X";
        Boolean jogar, jogando = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void finalizar(){
            jogando = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void testarCondicao()
        {
            if((button1.Text == button2.Text) && (button1.Text == button3.Text))
            {
                MessageBox.Show(vez_jogador + " Venceu!!!");
            }
        }

        private void gerarNumero()
        {
            if (jogando)
            {

                Random randomNumber = new Random();
                int numeroAleatorio = randomNumber.Next(1, 9);
                jogar = false;

                switch (numeroAleatorio)
                {
                    case 1:
                        if (button1.Text == "") preencherButton(button1);
                        else gerarNumero();
                        break;
                    case 2:
                        if (button2.Text == "") preencherButton(button2);
                        else gerarNumero();
                        break;
                    case 3:
                        if (button3.Text == "") preencherButton(button3);
                        else gerarNumero();
                        break;
                    case 4:
                        if (button4.Text == "") preencherButton(button4);
                        else gerarNumero();
                        break;
                    case 5:
                        if (button5.Text == "") preencherButton(button5);
                        else gerarNumero();
                        break;
                    case 6:
                        if (button6.Text == "") preencherButton(button6);
                        else gerarNumero();
                        break;
                    case 7:
                        if (button7.Text == "") preencherButton(button7);
                        else gerarNumero();
                        break;
                    case 8:
                        if (button8.Text == "") preencherButton(button8);
                        else gerarNumero();
                        break;
                    case 9:
                        if (button9.Text == "") preencherButton(button9);
                        else gerarNumero();
                        break;
                }
            }
        }

        private void preencherButton(Button botao)
        {
            if (jogando)
            {
                if (botao.Text == "")
                {
                    botao.Text = vez_jogador;
                    testarCondicao();
                    if (vez_jogador == "X") vez_jogador = "O";
                    else if (vez_jogador == "O") vez_jogador = "X";
                }
                if (jogar && jogando) { gerarNumero(); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //O sender é o objeto que disparou o evento, que neste caso é o button7. O as Button é uma conversão segura que atribui null se a conversão falhar.
            Button botao = sender as Button;
            jogar = true;
            preencherButton(botao);        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            jogar = true;
            preencherButton(botao);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            jogar = true;
            preencherButton(botao);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            jogar = true;
            preencherButton(botao);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            jogar = true;
            preencherButton(botao);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            jogar = true;
            preencherButton(botao);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            jogar = true;
            preencherButton(botao);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            jogar = true;
            preencherButton(botao);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            jogar = true;
            preencherButton(botao);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var botoesNumerados = new List <Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (var botao in botoesNumerados)
            {
                botao.Text = "";
            }

            vez_jogador = "X";
            jogar = true;
            jogando = true;
            MessageBox.Show("Novo jogo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
