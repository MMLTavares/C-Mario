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
            /*
            Cor cor = new Cor();
            Game jogo = new Game();
            jogo.escolherCores(5, 0);
            jogo.escolherCores(6, 1);
            jogo.escolherCores(8, 2);
            jogo.escolherCores(3, 3);

            int[,] coresEscolhidas = jogo.escolha();
            int[,] res = jogo.verificar(coresEscolhidas);

            int[] sorteio = cor.sorteio();

            Console.WriteLine(sorteio[0].ToString());
            Console.WriteLine(sorteio[1].ToString());
            Console.WriteLine(sorteio[2].ToString());
            Console.WriteLine(sorteio[3].ToString());
            Console.WriteLine("-----------------");

            Console.WriteLine(res[0, 0].ToString());
            Console.WriteLine(res[0, 1].ToString());
            Console.WriteLine(res[0, 2].ToString());
            Console.WriteLine(res[0, 3].ToString());
            */

            //aparece o menu início
            MenuInicio jogar = new MenuInicio();
            jogar.ImprimirMenu1();


            //guardar o input do user numa variável
            string input1 = Console.ReadLine();
            //conversão do input do user
            int conv = Convert.ToInt32(input1);

            

            if (conv == 1)
            {
                
                int[,] coresEscolhidas;

                //iniciar tela de jogo
                Menu menu = new Menu();
                menu.ImprimirTelaJogo();
                Jogo jogo = new Jogo();
                Perguntas perguntar = new Perguntas(jogo);

                do
                {
                    perguntar.Perguntar();
                    coresEscolhidas = jogo.escolha();
                    int[,] resultado = jogo.verificar(coresEscolhidas);

                    menu.ImprimirTelaJogo(coresEscolhidas, resultado);
                    if (jogo.ganhar())
                    {
                        Console.WriteLine("GANHOU!!!!");
                        break;
                    }
                } while (jogo.numTentativas < 10);
                Console.WriteLine("Que pena, você perdeu! :( ");

            }
            else
            {
                Console.WriteLine("Carregue em qualquer tecla para sair do jogo.");
            }

        }
     
    }
}
