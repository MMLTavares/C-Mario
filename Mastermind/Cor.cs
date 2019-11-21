using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    public class Cor
    {

        Dictionary<string, int> cores = new Dictionary<string, int>()
        {
            {"Azul", 0},
            {"Verde", 1},
            {"Amarelo", 2},
            {"Vermelho", 3},
            {"Branco", 4},
            {"Rosa", 5},
            {"Castanho", 6},
            {"Violeta", 7},
            {"Preto", 8},
            {"Laranja", 9},
        };

        public int[] sorteio()
        {
            Random rand = new Random();

            Dictionary<string, int> corRand = cores.OrderBy(x => rand.Next())
                .ToDictionary(item => item.Key, item => item.Value);

            int[] coresSorteio = new int[4];

            int i = 0;

            foreach (var pair in corRand)
            {
                coresSorteio[i] = pair.Value;
                i++;
                if (i == 4) break;
            }
            return coresSorteio;
        }

    }
}
