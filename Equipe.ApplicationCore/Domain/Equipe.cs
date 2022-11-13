using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Equipe.ApplicationCore.Domain
{
    public class Equipe
    {
        public String AdressLocal { get; set; }
        public int  EquipeId { get; set; }
        public String EquipeName { get; set; }
        public String Logo { get; set; }
        public ICollection<Contrat> Contrats { get; set; }
        public ICollection<Trophe> Trophes { get; set; }
    }
}
