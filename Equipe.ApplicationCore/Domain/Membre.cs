using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipe.ApplicationCore.Domain
{
    public class Membre
    {
        DateTime Datenaissance { get; set; }
        int identifiant { get; set; }
        String nom { get; set; }
        String prenom { get; set; }
        public ICollection<Contrat> Contrats { get; set; }
    }
}
