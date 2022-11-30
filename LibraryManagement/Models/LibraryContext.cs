using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Models
{
    internal class LibraryContext : DbContext
    {
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Responsable> Responsables { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Ouvrage> Ouvrages { get; set; }
        public DbSet<Periodique> Periodiques { get; set; }
        public DbSet<CD> CDs { get; set; }
        public DbSet<Livre> Livres { get; set; }
        public DbSet<Emprunt> Emprunts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=Library;uid=root;password=", new MySqlServerVersion(new Version(8, 0, 30)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Utilisateur>().Property("Discriminator").HasMaxLength(100);
            modelBuilder.Entity<Ouvrage>().HasDiscriminator(o => o.Type);
        }
    }
}
