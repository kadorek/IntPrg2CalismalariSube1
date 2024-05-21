using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Fihrist.Models;

public partial class FihristContext : DbContext
{
    public FihristContext()
    {
    }

    public FihristContext(DbContextOptions<FihristContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Info> Infos { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleUser> RoleUsers { get; set; }

    public virtual DbSet<Type> Types { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=.\\\\\\\\Data\\\\\\\\fihrist.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Info>(entity =>
        {
            entity.ToTable("Info");

            entity.HasOne(d => d.Person).WithMany(p => p.Infos)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Type).WithMany(p => p.Infos)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.ToTable("Person");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("Role");
        });

        modelBuilder.Entity<RoleUser>(entity =>
        {
            entity.ToTable("RoleUser");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.User).WithMany(p => p.RoleUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Type>(entity =>
        {
            entity.ToTable("Type");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
