using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoVerseny
{
    class Versenyzo
    {
        public string Csapat { get; set; }
        public string VersenyzoNeve { get; set; }
        public int Eletkor { get; set; }
        public string Palya { get; set; }
        public TimeSpan Korido { get; set; }
        public int Kor { get; set; }

        public Versenyzo(string csapat, string versenyzoNeve, int eletkor, string palya, TimeSpan korido, int kor)
        {
            Csapat = csapat;
            VersenyzoNeve = versenyzoNeve;
            Eletkor = eletkor;
            Palya = palya;
            Korido = korido;
            Kor = kor;
        }

        public Versenyzo(string[] sor)
        {
            Csapat = sor[0];
            VersenyzoNeve = sor[1];
            Eletkor = Convert.ToInt32(sor[2]);
            Palya = sor[3];
            Korido = TimeSpan.Parse(sor[4]);
            Kor = Convert.ToInt32(sor[5]);
        }

        
    }
}
