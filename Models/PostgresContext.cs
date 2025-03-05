using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LavenderMaster.Models
{
    public partial class PostgresContext : DbContext
    {
        public PostgresContext()
        {
        }

        public PostgresContext(DbContextOptions<PostgresContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Gernarals> Gernarals { get; set; }
        public virtual DbSet<Options> Options { get; set; }
        public virtual DbSet<Stations> Stations { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=SUPPORTDB;Username=postgres;Password=8545");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Gernarals>(entity =>
            {
                entity.ToTable("gernarals", "support");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityAlwaysColumn();

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<Options>(entity =>
            {
                entity.ToTable("options", "support");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityAlwaysColumn();

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<Stations>(entity =>
            {
                entity.ToTable("stations", "support");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityAlwaysColumn();

                entity.Property(e => e.Bu).HasColumnName("bu");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.IpBo).HasColumnName("ip_bo");

                entity.Property(e => e.IpSim).HasColumnName("ip_sim");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Pbl).HasColumnName("pbl");

                entity.Property(e => e.Plant).HasColumnName("plant");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users", "support");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseNpgsqlIdentityAlwaysColumn();

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.Role).HasColumnName("role");
            });
        }
    }
}
