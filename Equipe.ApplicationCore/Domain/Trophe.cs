using Equ.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eq.ApplicationCore.Domain
{
    public class Trophe
    {
        public DateTime DateTrophee { get; set; }
        public double Recompense { get; set; }
        public int TropheId { get; set; }
        public string TypeTrophee { get; set; }
        public Equipe equipe { get; set; }


    }
}
