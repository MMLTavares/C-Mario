using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroInterface
{
    public class CarroVW : ICarro
    {
        public decimal Velocidade { get; set; }
        public bool luz1 { get; set; }
        public bool luz2 { get; set; }
        public bool luz3 { get; set; }
        public bool luz4 { get; set ; }
        public string Roda1 { get; set; }
        public string Roda2 { get; set; }
        public string Roda3 { get; set; }
        public string Roda4 { get; set; }

        public bool TravaoDeMao()
        {
            return true;
        }
        public decimal Acelarar()
        {
           /* Console.WriteLine("Quanto queres acelarar?");
            string a = Console.ReadLine();
            int con = Convert.ToInt32(a);
            double OutputAcelarar = con * 0.5;
            Console.WriteLine($"Acelaraste {con} km/h.");*/

            return Velocidade = Velocidade + 0.5M;
        }

        public decimal Travar()
        {
            //Console.WriteLine("Quanto queres travar?");
            //string b = Console.ReadLine();
            //int conb = Convert.ToInt32(b);
            //double OutputTravar = conb * 0.5;
            //Console.WriteLine($"Travaste {conb} km/h.");

            return Velocidade = Velocidade - 0.5M;
        }
    }
}
