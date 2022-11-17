using Eq.ApplicationCore.Domain;
using Equ.ApplicationCore.Domain;
using Infrastruct.Configurations;
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

            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
            Initial Catalog=GestionEquipeDB;Integrated Security=true;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EquipeConfiguration());
            modelBuilder.ApplyConfiguration(new TropheConfig());
            modelBuilder.ApplyConfiguration(new MembreConfiguration());

            //configurer l'heritage Table par type TPT
            modelBuilder.Entity<Entraineur>().ToTable("Entraineur");
            modelBuilder.Entity<Joueur>().ToTable("Joueur");

            //configurer la table porteuse de donnée 
            modelBuilder.Entity<Contrat>().HasKey(C => new { C.equipeFK, C.membreFK });
            base.OnModelCreating(modelBuilder);


        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)

        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("Date");
            base.ConfigureConventions(configurationBuilder);
        }


    }


}