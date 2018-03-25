using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using AsMiceToCheese.src;
using AsMiceToCheese.src.Configurations;

namespace AsMiceToCheese
{
    public partial class Form1 : Form
    {
        private Config configuracoes;
        private List<Vector2[]> individuos;
        public Form1()
        {
            InitializeComponent();
            comboBoxPosicaoQueijoX.SelectedIndex = 0;
            comboBoxPosicaoQueijoY.SelectedIndex = 0;
            comboBoxPosicaoRatoX.SelectedIndex = 0;
            comboBoxPosicaoRatoY.SelectedIndex = 0;
            comboBoxTamanhoPopulacao.SelectedIndex = 0;
            comboBoxTaxaCruzamento.SelectedIndex = 0;
            comboBoxTaxaMutacao.SelectedIndex = 0;
            comboBoxMecanismoSelecao.SelectedIndex = 0;
            individuos = new List<Vector2[]>();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            configuracoes = new Config(new Vector2(Int32.Parse(comboBoxPosicaoQueijoX.Text),
                                                    Int32.Parse(comboBoxPosicaoQueijoY.Text)),
                                                    new Vector2(Int32.Parse(comboBoxPosicaoRatoX.Text),
                                                    Int32.Parse(comboBoxPosicaoRatoY.Text)),
                                                    comboBoxTamanhoPopulacao.Text, comboBoxTaxaCruzamento.Text,
                                                    comboBoxTaxaMutacao.Text, comboBoxMecanismoSelecao.Text);
            configuracoes.PrintOnConsole();
            buttonConfirmar.Enabled = false;
            buttonStart.Enabled = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
                for (int i = 0; i < configuracoes.getTamanhoDaPopulacao(); i++)
                {
                    individuos.Add(CriarIndividuos());
                }
        }

        private Vector2[] CriarIndividuos()
        {
            Vector2[] aux = new Vector2[10];
            aux[0] = configuracoes.getPosicaoInicialRato();
            Random rnd = new Random();
            aux[1] = new Vector2(rnd.Next(1, 10), rnd.Next(1, 10));
            aux[2] = new Vector2(rnd.Next(1, 10), rnd.Next(1, 10));
            aux[3] = new Vector2(rnd.Next(1, 10), rnd.Next(1, 10));
            aux[4] = new Vector2(rnd.Next(1, 10), rnd.Next(1, 10));
            aux[5] = new Vector2(rnd.Next(1, 10), rnd.Next(1, 10));
            aux[6] = new Vector2(rnd.Next(1, 10), rnd.Next(1, 10));
            aux[7] = new Vector2(rnd.Next(1, 10), rnd.Next(1, 10));
            aux[8] = new Vector2(rnd.Next(1, 10), rnd.Next(1, 10));
            aux[9] = configuracoes.getPosicaoInicialQueijo();
            return aux;
        }
    }
}
