using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Equ.ApplicationCore.Domain;

namespace Infrastruct.Configurations
{
    public class EquipeConfiguration : IEntityTypeConfiguration<Equipe>
    {

        public void Configure(EntityTypeBuilder<Equipe> builder)
        {
            builder.HasKey(e => e.EquipeId);
            builder.ToTable("MyEquipe");
            builder.Property(e => e.Logo).HasColumnName("EquipeLogo");



           
        }
    }
}
