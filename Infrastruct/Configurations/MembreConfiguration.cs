using Eq.ApplicationCore.Domain;
using Equ.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastruct.Configurations
{
    public class MembreConfiguration : IEntityTypeConfiguration<Membre>
    {
        public void Configure(EntityTypeBuilder<Membre> builder)
        {
           /* builder.HasDiscriminator<int>("IsJoueur").
               HasValue<Membre>(0).
               HasValue<Joueur>(1).
               HasValue<Entraineur>(2);*/
        }
    }
}
