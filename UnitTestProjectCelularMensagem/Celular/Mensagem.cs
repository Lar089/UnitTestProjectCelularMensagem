using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectCelularMensagem.Celular
{
    class Mensagem
    {
        private char[] str;
        public string str_saida;
        private int valor_anterior;

        public Mensagem(string str_entrada)
        {
            str_entrada = str_entrada.ToUpper();
            this.str = str_entrada.ToCharArray();
            this.valor_anterior = 1;
            this.str_saida = GerarCadeia(str);

            Validar();
        }

        private void Validar()
        {
            if (str.Length > 250)
                str_saida = "Mensagem Inválida";

            if (str_saida.Length > 160)
                str_saida = "Mensagem Inválida";
        }

        private string GerarCadeia(char[] str)
        {
            char[] letras = str;
            string valores = "";
            foreach (var letra in letras)
            {
                valores += VerificaLetra(letra);
            }
            return valores;
        }

        private string VerificaLetra(char letra)
        {
            string cadeia = "";
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < valorTecla[i].Length; j++)
                {
                    if (letra == valorTecla[i][j])
                    {
                        int valor = i + 2;
                        int posicao = j + 1;
                        if (i + 2 == 10)
                        {
                            valor = 0;
                        }

                        if (valor_anterior == valor)
                        {
                            valor_anterior = valor;
                            cadeia = "_";
                        }
                        else
                        {
                            valor_anterior = valor;
                        }
                        cadeia = cadeia + ValorPosicao(posicao, valor);
                        return cadeia;
                    }
                }
            }
            return cadeia;
        }

        public char[][] valorTecla =
        {
            new char[] {'A','B','C'},
            new char[] {'D','E','F'},
            new char[] {'G','H','I'},
            new char[] {'J','K','L'},
            new char[] {'M','N','O'},
            new char[] {'P','Q','R','S'},
            new char[] {'T','U','V'},
            new char[] {'W','X','Y','Z'},
            new char[] {' '}
        };

        public string ValorPosicao(int posicao, int valor)
        {
            if (posicao == 1)
                return valor.ToString();
            else if (posicao == 2)
                return valor.ToString() + valor.ToString();
            else if (posicao == 3)
                return valor.ToString() + valor.ToString() + valor.ToString();
            else
                return valor.ToString() + valor.ToString() + valor.ToString() + valor.ToString();
        }
    }
}
