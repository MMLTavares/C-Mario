using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    public class Jogo
    {
        private int[,] coresEscolhidas = new int[10, 4];

        public int numTentativas = 0;

        private int[] sorteio;

        public int[,] resultado = new int[10, 4];

        public int pontuacao;
        public Jogo()
        {
            Cor cor = new Cor();
            sorteio = cor.sorteio();

        }

        public void escolherCores(int numCor, int i)
        {
            coresEscolhidas[numTentativas, i] = numCor;
        }

        public int[,] escolha()
        { 
            return coresEscolhidas;
        }
        public int[,] verificar(int[,] coresEscolhidas)
        {
            pontuacao = 0;
            for (int i = 0; i < coresEscolhidas.GetLength(1); i++)
            {
                int valor = 0;
                for (int j = 0; j < sorteio.Length; j++)
                {
                    if (coresEscolhidas[numTentativas, i] == sorteio[j])
                    {
                        if (i == j)
                        {
                            valor = 2;
                            break;
                        }
                        valor = 1;
                        break;
                    }
                }
                resultado[numTentativas, i] = valor;
                pontuacao += valor;
            }
            resultado = sortArray(resultado);
            numTentativas++;
           
            return resultado;
        }
        
        private int[,] sortArray (int[,] result)
        {
            int[] aux = new int[4];
            for (int i = 0; i < result.GetLength(1); i++)
            {
                aux[i] = result[numTentativas,i];
            }
            Array.Sort(aux);

            for (int i = 0; i < result.GetLength(1); i++)
            {
                result[numTentativas, i] = aux[i];
            }
            return result;
        }

        public bool ganhar(){
            if (pontuacao == 8)
                return true;
            return false;

        }


    }
}
