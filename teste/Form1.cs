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

        public Form1()
        {
            InitializeComponent();
        }

        private int gerarNumero()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 9);
            return numeroAleatorio;
        }

        private void preencherButton(Button botao)
        {
            if (botao.Text == "")
            {
                botao.Text = vez_jogador;
                if (vez_jogador == "X")
                {
                    vez_jogador = "O";
                }
                else if (vez_jogador == "O")
                {
                    vez_jogador = "X";
                }
            }
            int numero = gerarNumero();
            MessageBox.Show(numero.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //O sender é o objeto que disparou o evento, que neste caso é o button7. O as Button é uma conversão segura que atribui null se a conversão falhar.
            Button botao = sender as Button;
            preencherButton(botao);            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            preencherButton(botao);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            preencherButton(botao);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            preencherButton(botao);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            preencherButton(botao);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            preencherButton(botao);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            preencherButton(botao);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            preencherButton(botao);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
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
            MessageBox.Show("Novo jogo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
