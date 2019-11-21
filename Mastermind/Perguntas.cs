using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    public class Perguntas
    {
        public Jogo jogo;

        public Perguntas(Jogo _jogo)
        {
            this.jogo = _jogo;
        }

        public void Perguntar()
        {
            string escolha;
            for ( int i = 0; i < 4; i++)
            {
                Console.WriteLine("Qual o número da cor {0}?", i+1);
                escolha = Console.ReadLine();
                jogo.escolherCores(Convert.ToInt32(escolha), i);

            }
            

        }
    }
}
