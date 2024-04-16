using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Acquaintance;

public partial class HeartFlutteringContext : DbContext
{
    public HeartFlutteringContext()
    {
    }

    public HeartFlutteringContext(DbContextOptions<HeartFlutteringContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Administrator> Administrators { get; set; }

    public virtual DbSet<LoginPassword> LoginPasswords { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=../../../HeartFluttering.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administrator>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id).HasColumnType("GUID");
            entity.Property(e => e.Name).HasColumnType("TEXT (40)");
            entity.Property(e => e.Surname).HasColumnType("TEXT (40)");

            entity.HasOne(d => d.IdNavigation).WithMany()
                .HasForeignKey(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<LoginPassword>(entity =>
        {
            entity.ToTable("LoginPassword");

            entity.HasIndex(e => e.Id, "IX_LoginPassword_Id").IsUnique();

            entity.HasIndex(e => e.Login, "IX_LoginPassword_Login").IsUnique();

            entity.HasIndex(e => e.Password, "IX_LoginPassword_Password").IsUnique();

            entity.Property(e => e.Login).HasColumnType("TEXT (50)");
            entity.Property(e => e.Password).HasColumnType("TEXT (100)");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.DateOfBirth).HasColumnType("DATETIME");
            entity.Property(e => e.Name).HasColumnType("TEXT (40)");
            entity.Property(e => e.Number).HasColumnType("INT64");
            entity.Property(e => e.Sex).HasColumnType("BOOLEAN");
            entity.Property(e => e.Surname).HasColumnType("TEXT (40)");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.User)
                .HasForeignKey<User>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
