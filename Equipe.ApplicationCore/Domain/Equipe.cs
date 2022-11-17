using Eq.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Equ.ApplicationCore.Domain
{
    public class Equipe
    {
        public String AdressLocal { get; set; }
        [Key]
        public int EquipeId { get; set; }
        [StringLength(8)]
        public String EquipeName { get; set; }
        public String Logo { get; set; }
      
        public virtual ICollection<Contrat> Contrats { get; set; }
        public virtual ICollection<Trophe> Trophes { get; set; }
    }
}
