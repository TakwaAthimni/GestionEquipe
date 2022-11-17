using Equ.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
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

        public virtual Equipe equipe { get; set; }
        [ForeignKey("Equipe ")]
        public int EquipeFK { get; set; }
    }
}
