using Eq.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastruct.Configurations
{
    public class TropheConfig : IEntityTypeConfiguration<Trophe>
    {
        public void Configure(EntityTypeBuilder<Trophe> builder)
        {
            //configurer la relation one to many 
            builder.HasOne(t => t.equipe).WithMany(e => e.Trophes).HasForeignKey(t => t.EquipeFK).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
    
}
