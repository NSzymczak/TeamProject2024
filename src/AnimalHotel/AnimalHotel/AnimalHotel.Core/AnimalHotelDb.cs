using AnimalHotel.Core.Model;
using AnimalHotel.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;

namespace AnimalHotel.Core;

public partial class AnimalHotelDb : DbContext
{
    public virtual DbSet<Animal> Animal { get; set; }
    public virtual DbSet<DailyActivity> DailyActivity { get; set; }
    public virtual DbSet<Details> DogDetails { get; set; }
    public virtual DbSet<FeedingRules> FeedingRules { get; set; }
    public virtual DbSet<Health> Health { get; set; }
    public virtual DbSet<Owner> Owner { get; set; }
    public virtual DbSet<Visit> Visit { get; set; }
    public virtual DbSet<WalksRules> WalksRules { get; set; }
    public virtual DbSet<User> User { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DailyActivity>(entity =>
        {
            entity.HasKey(e => e.ID);
        });
        modelBuilder.Entity<Animal>(entity =>
        {
            entity.HasOne(a => a.Details)
                  .WithOne(d => d.Animal)
                  .HasForeignKey<Details>(d => d.AnimalID);
            entity.HasOne(a => a.FeedingRules)
                  .WithOne(fr => fr.Animal)
                  .HasForeignKey<FeedingRules>(fr => fr.AnimalID);
            entity.HasOne(a => a.Health)
                  .WithOne(h => h.Animal)
                  .HasForeignKey<Health>(h => h.AnimalID);
            entity.HasOne(a => a.WalkRules)
                  .WithOne(wr => wr.Animal)
                  .HasForeignKey<WalksRules>(wr => wr.AnimalID);
        });
        modelBuilder.Entity<Details>(entity =>
        {
            entity.HasKey(e => e.ID);
        });
        modelBuilder.Entity<FeedingRules>(entity =>
        {
            entity.HasKey(e => e.ID);
        });
        modelBuilder.Entity<Health>(entity =>
        {
            entity.HasKey(e => e.ID);
        });
        modelBuilder.Entity<Owner>(entity =>
        {
            entity.HasKey(e => e.ID);
        });
        modelBuilder.Entity<Visit>(entity =>
        {
            entity.HasKey(e => e.ID);
        });
        modelBuilder.Entity<WalksRules>(entity =>
        {
            entity.HasKey(e => e.ID);
        });
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.ID);
        });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=MSI;Initial Catalog=AnimalHotel;Persist Security Info=True;Encrypt=False;User ID=Natka;Password=123456");
    }
}