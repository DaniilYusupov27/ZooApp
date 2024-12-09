using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ZooApp.Models;

public partial class ZooDbContext : DbContext
{
    public ZooDbContext()
    {
    }

    public ZooDbContext(DbContextOptions<ZooDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Animal> Animals { get; set; }

    public virtual DbSet<AnimalAssignment> AnimalAssignments { get; set; }

    public virtual DbSet<Enclosure> Enclosures { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\Sqlexpress; DataBase=ZooDB; User=исп-32; Password=1234567890; Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Animal>(entity =>
        {
            entity.HasKey(e => e.AnimalId).HasName("PK__Animals__A21A73279EFD1F10");

            entity.Property(e => e.AnimalId)
                .ValueGeneratedNever()
                .HasColumnName("AnimalID");
            entity.Property(e => e.Habitat)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Species)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AnimalAssignment>(entity =>
        {
            entity.HasKey(e => e.AssignmentId).HasName("PK__AnimalAs__32499E57AA1E9D5B");

            entity.Property(e => e.AssignmentId)
                .ValueGeneratedNever()
                .HasColumnName("AssignmentID");
            entity.Property(e => e.AnimalId).HasColumnName("AnimalID");
            entity.Property(e => e.EnclosureId).HasColumnName("EnclosureID");

            entity.HasOne(d => d.Animal).WithMany(p => p.AnimalAssignments)
                .HasForeignKey(d => d.AnimalId)
                .HasConstraintName("FK_Animal");

            entity.HasOne(d => d.Enclosure).WithMany(p => p.AnimalAssignments)
                .HasForeignKey(d => d.EnclosureId)
                .HasConstraintName("FK_Enclosure");
        });

        modelBuilder.Entity<Enclosure>(entity =>
        {
            entity.HasKey(e => e.EnclosureId).HasName("PK__Enclosur__4A63C52C776BB924");

            entity.Property(e => e.EnclosureId)
                .ValueGeneratedNever()
                .HasColumnName("EnclosureID");
            entity.Property(e => e.EnclosureName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
