using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using MongoDB.EntityFrameworkCore.Extensions;
using SoftwareHouse.Domain.Entities;

namespace SoftwareHouse.Infrastructure.Repositories.EFCore
{
    public class SoftwareHouseDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Cost> Costs { get; set; }


        public static SoftwareHouseDbContext Create(IMongoDatabase database) =>
           new(new DbContextOptionsBuilder<SoftwareHouseDbContext>()
              .UseMongoDB(database.Client,
                          database.DatabaseNamespace.DatabaseName).Options);

        public SoftwareHouseDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToCollection("Projects");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasBsonRepresentation(MongoDB.Bson.BsonType.ObjectId).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).HasMaxLength(300);
                entity.Property(e => e.Description).HasMaxLength(1000);
                entity.Property(e => e.Active);
                entity.Property(e => e.Type);
                entity.Property(e => e.Status);
                entity.Property(e => e.BudgetId);
                entity.Property(e => e.Budget);
                entity.Property(e => e.Customer);
                entity.Property(e => e.CustomerId);
                entity.Property(e => e.CreatAt);
                entity.Property(e => e.StartDate);
                entity.Property(e => e.EndDate);
            });


            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToCollection("Customers");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .HasBsonRepresentation(MongoDB.Bson.BsonType.ObjectId).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).HasMaxLength(300);
                entity.Property(e => e.Description).HasMaxLength(1000);
                entity.Property(e => e.Active);
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.Property(e => e.IdentificationNumber).HasMaxLength(50);
                entity.Property(e => e.Responsible).HasMaxLength(100);
                entity.Property(e => e.Phone).HasMaxLength(20);
                entity.Property(e => e.Owner).HasMaxLength(100);
                entity.HasMany(e => e.Projects)
                      .WithOne(e => e.Customer)
                      .HasForeignKey(e => e.CustomerId)
                      .OnDelete(DeleteBehavior.Cascade);

            });


            modelBuilder.Entity<Budget>(entity =>
            {
                entity.ToCollection("Budgets");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .HasBsonRepresentation(MongoDB.Bson.BsonType.ObjectId).ValueGeneratedOnAdd();
                entity.Property(e => e.Description).HasMaxLength(1000);
                entity.Property(e => e.Active);
                entity.Property(e => e.Type);
                entity.Property(e => e.Costs);
                entity.Property(e => e.CostTotal);
            });

            modelBuilder.Entity<Cost>(entity =>
            {
                entity.ToCollection("Costs");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .HasBsonRepresentation(MongoDB.Bson.BsonType.ObjectId).ValueGeneratedOnAdd();
                entity.Property(e => e.Description).HasMaxLength(1000);
                entity.Property(e => e.Active);
                entity.Property(e => e.QuantityOfResources);
                entity.Property(e => e.Amount);
                entity.Property(e => e.Type);
            });

        }
    }
}
