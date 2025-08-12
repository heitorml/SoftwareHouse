using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SoftwareHouse.Domain.Entities;

namespace SoftwareHouse.Infrastructure.Repositories.EFCore
{
    public class SoftwareHouseDbContext : DbContext
    {
        public DbSet<Project> Projects { get; init; }
        public DbSet<Customer> Customers { get; init; }
        public DbSet<Budget> Budgets { get; init; }
        public DbSet<Cost> Costs { get; init; }
        public DbSet<User> Users { get; init; }


        public SoftwareHouseDbContext(
            DbContextOptions<SoftwareHouseDbContext> options)
            : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);





            //modelBuilder.Entity<Project>(entity =>
            //{
             
            //    entity.ToTable("Projects");
            //    entity.HasKey(e => e.Id);

            //    entity.Property(e => e.Name).HasMaxLength(300);
            //    entity.Property(e => e.Description).HasMaxLength(1000);
            //    entity.Property(e => e.Active);
            //    entity.Property(e => e.Type);
            //    entity.Property(e => e.Status);
            //    entity.Property(e => e.BudgetId);
            //    entity.Property(e => e.Budget);
            //    entity.Property(e => e.Customer);
            //    entity.Property(e => e.CustomerId);
            //    entity.Property(e => e.CreatAt);
            //    entity.Property(e => e.StartDate);
            //    entity.Property(e => e.EndDate);
            //});


            //modelBuilder.Entity<Customer>(entity =>
            //{
            //    entity.ToCollection("Customers");
            //    //entity.HasKey(e => e.Id);
            //    //entity.Property(e => e.Id)
            //    //    .HasBsonRepresentation(MongoDB.Bson.BsonType.ObjectId).ValueGeneratedOnAdd();
            //    //entity.Property(e => e.Name).HasMaxLength(300);
            //    //entity.Property(e => e.Description).HasMaxLength(1000);
            //    //entity.Property(e => e.Active);
            //    //entity.Property(e => e.Email).HasMaxLength(100);
            //    //entity.Property(e => e.IdentificationNumber).HasMaxLength(50);
            //    //entity.Property(e => e.Responsible).HasMaxLength(100);
            //    //entity.Property(e => e.Phone).HasMaxLength(20);
            //    //entity.Property(e => e.Owner).HasMaxLength(100);
            //    //entity.Property(e => e.Projects);

            //});


            //modelBuilder.Entity<Budget>(entity =>
            //{
            //    entity.ToCollection("Budgets");
            //    //entity.HasKey(e => e.Id);
            //    //entity.Property(e => e.Id)
            //    //    .HasBsonRepresentation(MongoDB.Bson.BsonType.ObjectId).ValueGeneratedOnAdd();
            //    //entity.Property(e => e.Description).HasMaxLength(1000);
            //    //entity.Property(e => e.Active);
            //    //entity.Property(e => e.Type);
            //    ////entity.Property(e => e.Costs);
            //    //entity.Property(e => e.CostTotal);
            //});

            //modelBuilder.Entity<Cost>(entity =>
            //{
            //    entity.ToCollection("Costs");
            //    //entity.HasKey(e => e.Id);
            //    //entity.Property(e => e.Id)
            //    //    .HasBsonRepresentation(MongoDB.Bson.BsonType.ObjectId).ValueGeneratedOnAdd();
            //    //entity.Property(e => e.Description).HasMaxLength(1000);
            //    //entity.Property(e => e.Active);
            //    //entity.Property(e => e.QuantityOfResources);
            //    //entity.Property(e => e.Amount);
            //    //entity.Property(e => e.Type);
            //});


            //modelBuilder.Entity<User>(entity =>
            //{
            //    entity.ToCollection("Users");
            //    //entity.HasKey(e => e.Id);
            //    //entity.Property(e => e.Id)
            //    //    .HasBsonRepresentation(MongoDB.Bson.BsonType.ObjectId).ValueGeneratedOnAdd();
            //    //entity.Property(e => e.Active);
            //    //entity.Property(e => e.Password);
            //    //entity.Property(e => e.Username);
            //    //entity.Property(e => e.CreatedAt);
            //    //entity.Property(e => e.Email);
            //    //entity.Property(e => e.FullName);
            //    //entity.Property(e => e.UpdatedAt);
            //    //entity.Property(e => e.Type);
            //});

        }
    }
}
