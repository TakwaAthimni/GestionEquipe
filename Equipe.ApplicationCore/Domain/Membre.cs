using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eq.ApplicationCore.Domain
{
    public class Membre
    {
        public int MembreId { get; set; }
        public DateTime Datenaissance { get; set; }
        public int identifiant { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public virtual ICollection<Contrat> Contrats { get; set; }
    }
}
