using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroInterface
{
    public interface ICarro
    {
        // luzes frontais
        bool luz1 { get; set; }
        bool luz2 { get; set; }
        // luzes traseiras
        bool luz3 { get; set; }
        bool luz4 { get; set; }

        // rodas frontais
        string Roda1 { get; set; }
        string Roda2 { get; set; }
        // rodas traseiras
        string Roda3 { get; set; }
        string Roda4 { get; set; }

        //Travao de mao

        // acelarar
        decimal Acelarar();

        //travar
        decimal Travar();
        

    }
}
