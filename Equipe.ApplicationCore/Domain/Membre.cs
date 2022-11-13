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
        public String nom { get; set; }
        public String prenom { get; set; }
        public ICollection<Contrat> Contrats { get; set; }
    }
}
