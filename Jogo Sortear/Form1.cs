using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Sortear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            Random dado = new Random(); // Cria uma nova instancia da Classe Randon para gerar numeros aleatorios
            int valor; // Declara uma variavel do tipo inteiro chamada 'valor'

            valor = dado.Next(1, 4); // Atribui a variavel 'valor' um numero aleatorio entre 1 e 3 

            if (valor == 1) // Verifica se o valor gerado é igual a 1
            {
                imgDS.Visible = true;  // Se for igual a 1, torna visivel a imagem do Death Stranding
                imgER.Visible = false; // Esconde a imagem do Elden Ring
                imgHK.Visible = false; // Esconde a imagme do Hollow Knight
            }
            if (valor == 2)
            {
                imgDS.Visible = false;
                imgER.Visible = true;
                imgHK.Visible = false;
            }
            if (valor == 3)
            {
                imgDS.Visible = false;
                imgER.Visible = false;
                imgHK.Visible = true;
            }
        }
    }
}
