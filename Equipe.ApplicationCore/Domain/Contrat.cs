using Equ.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eq.ApplicationCore.Domain
{
    public class Contrat
    {    
        public int Id { get; set; }
        public DateTime DateContrat { get; set; }
        public int DureeMois { get; set; }
        public double salaire { get; set; }
        

        public Membre Membre { get; set; }
        
        public Equipe Equipe { get; set; }


    }
}
