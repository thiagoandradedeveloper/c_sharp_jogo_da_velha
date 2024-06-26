﻿using System;
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
        int[] numeros = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        private static Random randomNumber = new Random(); // Reutilizar a mesma instância de Random

        public Form1()
        {
            InitializeComponent();
        }


        private void finalizar(){
            jogando = false;
            jogar   = false;
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
            if((button1.Text == button2.Text) && (button1.Text == button3.Text) && button1.Text != "" && button2.Text != "" && button3.Text != "")
            {
                MessageBox.Show(vez_jogador + " Venceu!!!");
                finalizar();
            }
            else if ((button4.Text == button5.Text) && (button4.Text == button6.Text) && button4.Text != "" && button5.Text != "" && button6.Text != "")
            {
                MessageBox.Show(vez_jogador + " Venceu!!!");
                finalizar();
            }
            else if ((button7.Text == button8.Text) && (button7.Text == button9.Text) && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show(vez_jogador + " Venceu!!!");
                finalizar();
            }
            else if ((button1.Text == button4.Text) && (button1.Text == button7.Text) && button1.Text != "" && button4.Text != "" && button7.Text != "")
            {
                MessageBox.Show(vez_jogador + " Venceu!!!");
                finalizar();
            }
            else if ((button2.Text == button5.Text) && (button2.Text == button8.Text) && button2.Text != "" && button5.Text != "" && button8.Text != "")
            {
                MessageBox.Show(vez_jogador + " Venceu!!!");
                finalizar();
            }
            else if ((button3.Text == button6.Text) && (button3.Text == button9.Text) && button3.Text != "" && button6.Text != "" && button9.Text != "")
            {
                MessageBox.Show(vez_jogador + " Venceu!!!");
                finalizar();
            }
            else if ((button1.Text == button5.Text) && (button1.Text == button9.Text) && button1.Text != "" && button5.Text != "" && button9.Text != "")
            {
                MessageBox.Show(vez_jogador + " Venceu!!!");
                finalizar();
            }
            else if ((button3.Text == button5.Text) && (button3.Text == button7.Text) && button3.Text != "" && button5.Text != "" && button7.Text != "")
            {
                MessageBox.Show(vez_jogador + " Venceu!!!");
                finalizar();
            }
            else
            {
                if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
                {
                    MessageBox.Show("Deu velha, ninguém venceu!!!");
                    finalizar();
                }
            }
        }

        private int metodoNumeroAleatorio()
        {
            int numeroAleatorio;

            // Tentar encontrar um número aleatório que corresponda a um botão vazio
            do
            {
                numeroAleatorio = randomNumber.Next(1, 10); // Gera um número de 1 a 9 (inclusivo)
            } while (IsButtonOccupied(numeroAleatorio));

            return numeroAleatorio;
        }

        private bool IsButtonOccupied(int numeroAleatorio)
        {
            switch (numeroAleatorio)
            {
                case 1: return !string.IsNullOrEmpty(button1.Text);
                case 2: return !string.IsNullOrEmpty(button2.Text);
                case 3: return !string.IsNullOrEmpty(button3.Text);
                case 4: return !string.IsNullOrEmpty(button4.Text);
                case 5: return !string.IsNullOrEmpty(button5.Text);
                case 6: return !string.IsNullOrEmpty(button6.Text);
                case 7: return !string.IsNullOrEmpty(button7.Text);
                case 8: return !string.IsNullOrEmpty(button8.Text);
                case 9: return !string.IsNullOrEmpty(button9.Text);
                default: return true; // Caso inesperado, tratar como ocupado
            }
        }

        private void gerarNumero()
        {

            jogar = false;
            int novoNumero = metodoNumeroAleatorio();
            numeros[novoNumero] = novoNumero;

            switch (novoNumero)
            {
                case 1:
                    preencherButton(button1);
                    break;
                case 2:
                    preencherButton(button2);
                    break;
                case 3:
                    preencherButton(button3);
                    break;
                case 4:
                    preencherButton(button4);
                    break;
                case 5:
                    preencherButton(button5);
                    break;
                case 6:
                    preencherButton(button6);
                    break;
                case 7:
                    preencherButton(button7);
                    break;
                case 8:
                    preencherButton(button8);
                    break;
                case 9:
                    preencherButton(button9);
                    break;
                case 0:
                    break;
            }
        }

        private void preencherButton(Button botao)
        {

            if (botao.Text == "")
            {
                if (jogando) botao.Text = vez_jogador;
                testarCondicao();
                if (vez_jogador == "X") vez_jogador = "O";
                else if (vez_jogador == "O") vez_jogador = "X";
                if (jogar) gerarNumero();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //O sender é o objeto que disparou o evento, que neste caso é o button7. O as Button é uma conversão segura que atribui null se a conversão falhar.
            Button botao = sender as Button;
            jogar = true;
            numeros[1] = 1;
            preencherButton(botao);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            jogar = true;
            numeros[6] = 6;
            preencherButton(botao);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            jogar = true;
            numeros[7] = 7;
            preencherButton(botao);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            jogar = true;
            numeros[2] = 2;
            preencherButton(botao);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            jogar = true;
            numeros[5] = 5;
            preencherButton(botao);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            jogar = true;
            numeros[4] = 4;
            preencherButton(botao);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            jogar = true;
            numeros[3] = 3;
            preencherButton(botao);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            jogar = true;
            numeros[8] = 8;
            preencherButton(botao);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            jogar = true;
            numeros[9] = 9;
            preencherButton(botao);
        }

        private int[] GetNumeros()
        {
            return numeros;
        }


        private void reset_Click(object sender, EventArgs e)
        {

            var botoesNumerados = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (var botao in botoesNumerados)
            {
                botao.Text = "";
            }

            vez_jogador = "X";
            jogar = true;
            jogando = true;
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = true;
            MessageBox.Show("Novo jogo");

            for (int i = 1; i <= 9; i++) { numeros[i] = 0; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
