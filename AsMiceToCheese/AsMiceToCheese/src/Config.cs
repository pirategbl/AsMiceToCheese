using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsMiceToCheese.src.Configurations
{
    class Config
    {
        private Vector2 posicaoInicialQueijo;
        private Vector2 posicaoInicialRato;
        private int tamanhoDaPopulacao;
        private float taxaDeCruzamento;
        private float taxaDeMutacao;
        private String mecanismoDeSelecao;

        public Config(Vector2 posQueijo, Vector2 posRato, String populacao, String cruzamento, String mutacao, String selecao)
        {
            this.posicaoInicialQueijo = posQueijo;
            this.posicaoInicialRato = posRato;
            this.tamanhoDaPopulacao = Int32.Parse(populacao);
            
            switch(cruzamento)
            {
                case "85%":
                    this.taxaDeCruzamento = 0.85f;
                    break;
                case "90%":
                    this.taxaDeCruzamento = 0.9f;
                    break;
            }
            
            switch(mutacao)
            {
                case "1%":
                    this.taxaDeMutacao = 0.01f;
                    break;
                case "3%":
                    this.taxaDeMutacao = 0.03f;
                    break;
                case "5%":
                    this.taxaDeMutacao = 0.05f;
                    break;
            }

            this.mecanismoDeSelecao = selecao;
        }

        public Vector2 getPosicaoInicialQueijo()
        {
            return this.posicaoInicialQueijo;
        }

        public void setPosicaoInicialQueijo(Vector2 posQueijo)
        {
            this.posicaoInicialQueijo = posQueijo;
        }

        public Vector2 getPosicaoInicialRato()
        {
            return this.posicaoInicialRato;
        }

        public void setPosicaoInicialRato(Vector2 posRato)
        {
            this.posicaoInicialRato = posRato;
        }

        public int getTamanhoDaPopulacao()
        {
            return this.tamanhoDaPopulacao;
        }

        public void setTamanhoDaPopulacao(String populacao)
        {
            this.tamanhoDaPopulacao = Int32.Parse(populacao);
        }

        public float getTaxaDeCruzamento()
        {
            return this.taxaDeCruzamento;
        }

        public void setTaxaDeCruzamento(String cruzamento)
        {
            switch (cruzamento)
            {
                case "85%":
                    this.taxaDeCruzamento = 0.85f;
                    break;
                case "90%":
                    this.taxaDeCruzamento = 0.9f;
                    break;
            }
        }

        public float getTaxaDeMutacao()
        {
            return this.taxaDeMutacao;
        }

        public void setTaxaDeMutacao(String mutacao)
        {
            switch (mutacao)
            {
                case "1%":
                    this.taxaDeMutacao = 0.01f;
                    break;
                case "3%":
                    this.taxaDeMutacao = 0.03f;
                    break;
                case "5%":
                    this.taxaDeMutacao = 0.05f;
                    break;
            }
        }

        public String getMecanismoDeSelecao()
        {
            return this.mecanismoDeSelecao;
        }

        public void setMecanismoDeSelecao(String selecao)
        {
            this.mecanismoDeSelecao = selecao;
        }

        public void PrintOnConsole()
        {
            System.Console.WriteLine("Posição Inicial do Queijo em X: " + posicaoInicialQueijo.X);
            System.Console.WriteLine("Posição Inicial do Queijo em Y: " + posicaoInicialQueijo.Y);
            System.Console.WriteLine("Posição Inicial do Rato em X: " + posicaoInicialRato.X);
            System.Console.WriteLine("Posição Inicial do Rato em Y: " + posicaoInicialRato.Y);
            System.Console.WriteLine("Tamanho da População: " + tamanhoDaPopulacao);
            System.Console.WriteLine("Taxa de Cruzamento: " + taxaDeCruzamento);
            System.Console.WriteLine("Taxa de Mutação: " + taxaDeMutacao);
            System.Console.WriteLine("Mecanismo de Seleção: " + mecanismoDeSelecao);
        }
    }
}
