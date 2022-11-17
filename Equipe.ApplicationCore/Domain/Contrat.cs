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
        public DateTime DateContrat { get; set; }
        public int DureeMois { get; set; }
        public double salaire { get; set; }

        [ForeignKey("Membre")]
        public int membreFK { get; set; }
        public virtual Membre Membre { get; set; }

        [ForeignKey("Equipe")]
        public int equipeFK { get; set; }
        public virtual  Equipe Equipe { get; set; }


    }



}
