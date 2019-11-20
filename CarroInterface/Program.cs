using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroInterface
{
    class Program
    {

        static void Main(string[] args)
        {
            //Criar novo carro
            CarroSeat ibiza1 = new CarroSeat();

            // Loop while de acelaração e travagem

            Console.WriteLine("Baixar travão para andar. Carregar P");
            char travaom = char.Parse(Console.ReadLine());
            if (ibiza1.TravaoDeMao(travaom) == true)
            {


                while (true)
                {
                    // loop break
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        break;
                    }

                    // Acelaração
                    else if (Console.ReadKey().Key == ConsoleKey.UpArrow)
                    {
                        Console.Clear();
                        Console.WriteLine(ibiza1.Acelarar());

                        //Travagem
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.DownArrow)
                    {
                        Console.Clear();
                        Console.WriteLine(ibiza1.Travar());

                    }

                }
            }

            

        
          




        }
    }
}
