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
    public virtual DbSet<Visit> Visits { get; set; }
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
            entity.HasKey(e => e.ID);
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
        optionsBuilder.UseSqlServer("Data Source=MSI;Initial Catalog=HorseTracking;Persist Security Info=True;Encrypt=False;User ID=Natka;Password=123456");
    }
}