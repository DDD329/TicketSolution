using Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Persistence
{
    public class DomainContext : DbContext
    {
        public DbSet<Ticket> Tickets { get; set; }

        public DomainContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Tickets;Persist Security Info=True;User ID=sa;Password=Admin123$;Encrypt=false");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Ticket>()
                .HasKey(x => x.Id);

            modelBuilder
                .Entity<Ticket>()
                .Property(x => x.Subject)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder
                .Entity<Ticket>()
                .Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(1000);

            modelBuilder
                .Entity<Ticket>()
                .Property(x => x.CreatedDate)
                .IsRequired();
        }
    }
}