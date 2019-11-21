using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    public class Menu
    {


        public void ImprimirMenu1()
        {
            Console.WriteLine("                              ________________________________________________________");
            Console.WriteLine("                              __________________\\ MASTERMIND /________________________");
            Console.WriteLine("                                               __________________                       ");
            Console.WriteLine("                              --------------------------------------------------------");
            Console.WriteLine("                             |        Prima 1 para iniciar o jogo                     |");
            Console.WriteLine("                             |        Prima qualquer outro número para sair do jogo   |");
            Console.WriteLine("                              --------------------------------------------------------");


        }

        public void ImprimirTelaJogo( int[,] res , int[,] result )
        {
          
            //Tela de jogo
            Console.Clear();
            Console.WriteLine("_______________________________________________________________________________________________________________________");
            Console.WriteLine($"|                                                     MASTERMIND                                                      |");
            Console.WriteLine($"|            _________         _______                                          _______                               |");
            Console.WriteLine($"|            |Jogadas|         |Score|                                          |Cores|                               |");
            Console.WriteLine($"|                                                                                                                     |");
            Console.WriteLine($"|      [{res[0, 0]}] [{res[0, 1]}] [{res[0, 2]}] [{res[0, 3]}]  |   [{result[0, 0]}] [{result[0, 1]}] [{result[0, 2]}] [{result[0, 3]}]  |                           |    0  - azul                               |");
            Console.WriteLine($"|      [{res[1, 0]}] [{res[1, 1]}] [{res[1, 2]}] [{res[1, 3]}]  |   [{result[1, 0]}] [{result[1, 1]}] [{result[1, 2]}] [{result[1, 3]}]  |                           |    1  - verde                              |");
            Console.WriteLine($"|      [{res[2, 0]}] [{res[2, 1]}] [{res[2, 2]}] [{res[2, 3]}]  |   [{result[2, 0]}] [{result[2, 1]}] [{result[2, 2]}] [{result[2, 3]}]  |                           |    2  - amarelo                            |");
            Console.WriteLine($"|      [{res[3, 0]}] [{res[3, 1]}] [{res[3, 2]}] [{res[3, 3]}]  |   [{result[3, 0]}] [{result[3, 1]}] [{result[3, 2]}] [{result[3, 3]}]  |                           |    3  - vermelho                           |");
            Console.WriteLine($"|      [{res[4, 0]}] [{res[4, 1]}] [{res[4, 2]}] [{res[4, 3]}]  |   [{result[4, 0]}] [{result[4, 1]}] [{result[4, 2]}] [{result[4, 3]}]  |                           |    4  - branco                             |");
            Console.WriteLine($"|      [{res[5, 0]}] [{res[5, 1]}] [{res[5, 2]}] [{res[5, 3]}]  |   [{result[5, 0]}] [{result[5, 1]}] [{result[5, 2]}] [{result[5, 3]}]  |                           |    5  - rosa                               |");
            Console.WriteLine($"|      [{res[6, 0]}] [{res[6, 1]}] [{res[6, 2]}] [{res[6, 3]}]  |   [{result[6, 0]}] [{result[6, 1]}] [{result[6, 2]}] [{result[6, 3]}]  |                           |    6  - castanho                           |");
            Console.WriteLine($"|      [{res[7, 0]}] [{res[7, 1]}] [{res[7, 2]}] [{res[7, 3]}]  |   [{result[7, 0]}] [{result[7, 1]}] [{result[7, 2]}] [{result[7, 3]}]  |                           |    7  - violeta                            |");
            Console.WriteLine($"|      [{res[8, 0]}] [{res[8, 1]}] [{res[8, 2]}] [{res[8, 3]}]  |   [{result[8, 0]}] [{result[8, 1]}] [{result[8, 2]}] [{result[8, 3]}]  |                           |    8  - preto                              |");
            Console.WriteLine($"|      [{res[9, 0]}] [{res[9, 1]}] [{res[9, 2]}] [{res[9, 3]}]  |   [{result[9, 0]}] [{result[9, 1]}] [{result[9, 2]}] [{result[9, 3]}]  |                           |    9  - laranja                            |");
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
    }
}