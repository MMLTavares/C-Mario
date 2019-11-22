using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo = new Jogo();
            Menu menu = new Menu(jogo);

            int[,] coresEscolhidas, resultado;

            menu.ImprimirMenu1();

            string input1 = Console.ReadLine();

            if (input1 == "1")
            {               
                menu.ImprimirTelaJogo();
                do
                {
                    menu.Perguntar();

                    coresEscolhidas = jogo.coresEscolhidas;
                    resultado = jogo.Verificar(coresEscolhidas);

                    menu.ImprimirTelaJogo(coresEscolhidas, resultado);
                    if (jogo.Ganhar())
                    {
                        Console.WriteLine("GANHOU!!!!");
                        break;
                    }
                } while (jogo.numTentativas < 10);

                Console.WriteLine("Que pena, você perdeu! :( ");
                Console.WriteLine("A resposta certa era: ");
                jogo.ImprimirResultado();

            }

        }
     
    }
}
