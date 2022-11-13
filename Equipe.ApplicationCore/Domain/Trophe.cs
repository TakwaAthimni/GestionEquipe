using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipe.ApplicationCore.Domain
{
    public class Trophe
    {
        public DateTime DateTrophee { get; set; }
        public double Recompense { get; set; }
        public int TropheeId { get; set; }
        public string TypeTrophee { get; set; }
        public Equipe equipe { get; set; }


    }
}
