using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    public class Menu
    {
        private Jogo jogo;

        public Menu(Jogo _jogo)
        {
            this.jogo = _jogo;
        }

        public void ImprimirMenu1()
        {
            Console.WriteLine("                              ________________________________________________________");
            Console.WriteLine("                              __________________\\ MASTERMIND //______________________");
            Console.WriteLine("                                               __________________                       ");
            Console.WriteLine("                              --------------------------------------------------------");
            Console.WriteLine("                             |        Prima 1 para iniciar o jogo                     |");
            Console.WriteLine("                             |        Prima qualquer outro número para sair do jogo   |");
            Console.WriteLine("                              --------------------------------------------------------");


        }

        public void ImprimirTelaJogo( int[,] respostas , int[,] result )
        {
          

            //Tela de jogo
            Console.Clear();
            Console.WriteLine("_______________________________________________________________________________________________________________________");
            Console.WriteLine($"|                                                     MASTERMIND                                                      |");
            Console.WriteLine($"|            _________         _______                                          _______                               |");
            Console.WriteLine($"|            |Jogadas|         |Score|                                          |Cores|                               |");
            Console.WriteLine($"|                                                                                                                     |");
            Console.WriteLine($"|      [{respostas[0, 0]}] [{respostas[0, 1]}] [{respostas[0, 2]}] [{respostas[0, 3]}]  |   [{result[0, 0]}] [{result[0, 1]}] [{result[0, 2]}] [{result[0, 3]}]  |                           |    0  - azul                               |");
            Console.WriteLine($"|      [{respostas[1, 0]}] [{respostas[1, 1]}] [{respostas[1, 2]}] [{respostas[1, 3]}]  |   [{result[1, 0]}] [{result[1, 1]}] [{result[1, 2]}] [{result[1, 3]}]  |                           |    1  - verde                              |");
            Console.WriteLine($"|      [{respostas[2, 0]}] [{respostas[2, 1]}] [{respostas[2, 2]}] [{respostas[2, 3]}]  |   [{result[2, 0]}] [{result[2, 1]}] [{result[2, 2]}] [{result[2, 3]}]  |                           |    2  - amarelo                            |");
            Console.WriteLine($"|      [{respostas[3, 0]}] [{respostas[3, 1]}] [{respostas[3, 2]}] [{respostas[3, 3]}]  |   [{result[3, 0]}] [{result[3, 1]}] [{result[3, 2]}] [{result[3, 3]}]  |                           |    3  - vermelho                           |");
            Console.WriteLine($"|      [{respostas[4, 0]}] [{respostas[4, 1]}] [{respostas[4, 2]}] [{respostas[4, 3]}]  |   [{result[4, 0]}] [{result[4, 1]}] [{result[4, 2]}] [{result[4, 3]}]  |                           |    4  - branco                             |");
            Console.WriteLine($"|      [{respostas[5, 0]}] [{respostas[5, 1]}] [{respostas[5, 2]}] [{respostas[5, 3]}]  |   [{result[5, 0]}] [{result[5, 1]}] [{result[5, 2]}] [{result[5, 3]}]  |                           |    5  - rosa                               |");
            Console.WriteLine($"|      [{respostas[6, 0]}] [{respostas[6, 1]}] [{respostas[6, 2]}] [{respostas[6, 3]}]  |   [{result[6, 0]}] [{result[6, 1]}] [{result[6, 2]}] [{result[6, 3]}]  |                           |    6  - castanho                           |");
            Console.WriteLine($"|      [{respostas[7, 0]}] [{respostas[7, 1]}] [{respostas[7, 2]}] [{respostas[7, 3]}]  |   [{result[7, 0]}] [{result[7, 1]}] [{result[7, 2]}] [{result[7, 3]}]  |                           |    7  - violeta                            |");
            Console.WriteLine($"|      [{respostas[8, 0]}] [{respostas[8, 1]}] [{respostas[8, 2]}] [{respostas[8, 3]}]  |   [{result[8, 0]}] [{result[8, 1]}] [{result[8, 2]}] [{result[8, 3]}]  |                           |    8  - preto                              |");
            Console.WriteLine($"|      [{respostas[9, 0]}] [{respostas[9, 1]}] [{respostas[9, 2]}] [{respostas[9, 3]}]  |   [{result[9, 0]}] [{result[9, 1]}] [{result[9, 2]}] [{result[9, 3]}]  |                           |    9  - laranja                            |");
            Console.WriteLine($"|                                                                                                                     |");
            Console.WriteLine($"|                                                                                                                     |");
            Console.WriteLine($"|                                                                                                                     |");
            Console.WriteLine($"|                                                                                                                     |");
            Console.WriteLine($"-----------------------------------------------------------------------------------------------------------------------");

        }

        public void ImprimirTelaJogo()
        {
            int[,] res = new int[10,4];
            ImprimirTelaJogo(res, res);
        }

        public void Perguntar(int indice=0)
        {
            string escolha;
            for (int i = indice; i < 4; i++)
            {
                Console.WriteLine("Qual o número da cor {0}?", i + 1);

                escolha = Console.ReadLine();

                int escolhaInt;                
                try { 
                    escolhaInt = Convert.ToInt32(escolha); 
                    if(escolhaInt > 9)
                    {
                        Console.WriteLine("Valor Incorreto! ");
                        Perguntar(i);
                        break;
                    }
                }
                catch (FormatException) {
                    Console.WriteLine("Valor Incorreto! ");
                    Perguntar(i);
                    break;
                }

                jogo.EscolherCores(escolhaInt, i);

            }

        }

        
    }
}