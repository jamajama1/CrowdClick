using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Data
{
    public class CrowdClickDbContext: DbContext
    {
        //DbContext for database
        //put the connection in the constructor
        public CrowdClickDbContext(DbContextOptions<CrowdClickDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>(ConfigureProject);
            modelBuilder.Entity<Comment>(ConfigureComment);
            modelBuilder.Entity<Material>(ConfigureMaterial);
            modelBuilder.Entity<MaterialType>(ConfigureMaterialType);
            modelBuilder.Entity<Parameter>(ConfigureParameter);
            modelBuilder.Entity<Status>(ConfigureStatus);
            modelBuilder.Entity<StatusHistory>(ConfigureStatusHistory);
            modelBuilder.Entity<Update>(ConfigureUpdate);
            modelBuilder.Entity<UserProduct>(ConfigureUserProject);
            modelBuilder.Entity<Investor>(ConfigureInvestor);
            modelBuilder.Entity<ProductInvestment>(ConfigureProductInvestment);
            modelBuilder.Entity<InvestmentOption>(ConfigureInvestmentOption);
            modelBuilder.Entity<User>(ConfigureUser);
            modelBuilder.Entity<Country>(ConfigureCountry);
            modelBuilder.Entity<Member>(ConfigureMember);
            modelBuilder.Entity<ProductTeam>(ConfigureProductTeam);
            modelBuilder.Entity<Role>(ConfigureRole);
            modelBuilder.Entity<Vendor>(ConfigureVendor);
            modelBuilder.Entity<Product>(ConfigureProduct);
            modelBuilder.Entity<Category>(ConfigureCategory);
        }

        private void ConfigureCategory(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(24);
        }

        private void ConfigureProduct(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(p => new { p.Name, p.VendorId, p.Price });
            builder.Property(p => p.Name).HasMaxLength(200);
            builder.Property(p => p.Price).HasColumnType("decimal(5, 2)");
            builder.Property(p => p.Description).HasMaxLength(500);
        }

        private void ConfigureVendor(EntityTypeBuilder<Vendor> builder)
        {
            builder.ToTable("Vendor");
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Name).HasMaxLength(256);
        }

        private void ConfigureRole(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Role");
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Name).HasMaxLength(64);
        }

        private void ConfigureProductTeam(EntityTypeBuilder<ProductTeam> builder)
        {
            builder.ToTable("ProductTeam");
            builder.HasKey(p => p.Id);
        }

        private void ConfigureMember(EntityTypeBuilder<Member> builder)
        {
            builder.ToTable("Member");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.FirstName).HasMaxLength(64);
            builder.Property(p => p.LastName).HasMaxLength(64);
            builder.Property(p => p.Title).HasMaxLength(64);
        }

        private void ConfigureCountry(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Country");
            builder.Property(c => c.Name).HasMaxLength(256);
        }

        private void ConfigureUser(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.FirstName).HasMaxLength(64);
            builder.Property(u => u.LastName).HasMaxLength(64);
            builder.Property(u => u.Username).HasMaxLength(128);
            builder.Property(u => u.Password).HasMaxLength(256);
            builder.Property(u => u.Email).HasMaxLength(256);
            builder.Property(u => u.TotalAmount).HasColumnType("decimal(12, 2)");
        }

        private void ConfigureInvestmentOption(EntityTypeBuilder<InvestmentOption> builder)
        {
            builder.ToTable("InvestmentOption");
            builder.HasKey(io => io.Id);
            builder.Property(io => io.Name).HasMaxLength(256);
            builder.Property(io => io.FundsMin).HasColumnType("decimal(12, 2)");
            builder.Property(io => io.FundsMax).HasColumnType("decimal(12, 2)");
        }

        private void ConfigureProductInvestment(EntityTypeBuilder<ProductInvestment> builder)
        {
            builder.ToTable("ProductInvestment");
            builder.HasKey(pi => pi.Id);
            builder.Property(pi => pi.Name).HasMaxLength(256);
        }

        private void ConfigureInvestor(EntityTypeBuilder<Investor> builder)
        {
            builder.ToTable("Investor");
            builder.HasKey(i => i.Id);            
            builder.Property(i => i.Pledged).HasColumnType("decimal(12, 2)");
            builder.Property(i => i.TimeStamp).HasMaxLength(7);
        }

        private void ConfigureUserProject(EntityTypeBuilder<UserProduct> builder)
        {
            builder.ToTable("UserProduct");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.FirstName).HasMaxLength(64);
            builder.Property(u => u.LastName).HasMaxLength(64);
            builder.Property(u => u.Username).HasMaxLength(128);
            builder.Property(u => u.Password).HasMaxLength(255);
            builder.Property(u => u.Email).HasMaxLength(128);
            builder.Property(u => u.TotalAmount).HasColumnType("decimal(12, 2)");         
        }

        private void ConfigureUpdate(EntityTypeBuilder<Update> builder)
        {
            builder.ToTable("Update");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.TimeStamp).HasMaxLength(7);
        }

        private void ConfigureStatusHistory(EntityTypeBuilder<StatusHistory> builder)
        {
            builder.ToTable("StatusHistory");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.TimeStamp).HasMaxLength(7);
        }

        private void ConfigureStatus(EntityTypeBuilder<Status> builder)
        {
            builder.ToTable("Status");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Name).HasMaxLength(64);
        }

        private void ConfigureParameter(EntityTypeBuilder<Parameter> builder)
        {
            builder.ToTable("Parameter");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Goal).HasColumnType("decimal(12, 2)");
            builder.Property(p => p.TimeStamp).HasMaxLength(7);
        }

        private void ConfigureMaterialType(EntityTypeBuilder<MaterialType> builder)
        {
            builder.ToTable("MaterialType");
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Name).HasMaxLength(32);
        }

        private void ConfigureMaterial(EntityTypeBuilder<Material> builder)
        {
            builder.ToTable("Material");
            builder.HasKey(m => m.Id);
        }

        private void ConfigureComment(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comment");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.TimeStamp).HasMaxLength(7);
        }

        private void ConfigureProject(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasMaxLength(256);
            builder.Property(p => p.Goal).HasColumnType("decimal(12, 2)");
            builder.Property(p => p.Pledges).HasColumnType("decimal(12, 2)");
            builder.Property(p => p.StartTime).HasDefaultValueSql ("getdate()");
        }

        // DbSets for tables
        public DbSet<Product> Products { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<StatusHistory> StatusHistories { get; set; }
        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<MaterialType> MaterialTypes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Update> Updates { get; set; }
        public DbSet<UserProduct> UserProjects { get; set; }
        public DbSet<Investor> Investors { get; set; }
        public DbSet<ProductInvestment> ProductInvestments { get; set; }
        public DbSet<InvestmentOption> InvestmentOptions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<ProductTeam> ProductTeams { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
