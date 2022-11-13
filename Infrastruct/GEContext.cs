using Eq.ApplicationCore.Domain;
using Equ.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System.Numerics;


namespace Infrastruct
{
    public class GEContext : DbContext
    {
        public DbSet<Trophe> Trophes { get; set; }

        public DbSet<Joueur> Joueurs { get; set; }
        public DbSet<Equipe> Equipes { get; set; }

        public DbSet<Contrat> Contrats { get; set; }
        public DbSet<Entraineur> Entraineurs { get; set; }

        public DbSet<Membre> Membres { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
            Initial Catalog=GestionEquipeDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
    }

    
}