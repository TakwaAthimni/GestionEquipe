using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipe.ApplicationCore.Domain
{
    public class Contrat
    {
        public DateTime DateContrat { get; set; }
        public int DureeMois { get; set; }
        public double salaire { get; set; }
        

        public Membre Membre { get; set; }
        
        public Equipe Equipe { get; set; }


    }
}
