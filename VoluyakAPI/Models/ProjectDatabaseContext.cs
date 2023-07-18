using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VoluyakAPI.Models;

public partial class ProjectDatabaseContext : DbContext
{
    public ProjectDatabaseContext()
    {
    }

    public ProjectDatabaseContext(DbContextOptions<ProjectDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Description> Descriptions { get; set; }

    public virtual DbSet<Game> Games { get; set; }

    public virtual DbSet<Leaderbord> Leaderbords { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-Q3DPRDD;Initial Catalog=Project_database;Integrated Security=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Description>(entity =>
        {
            entity.HasKey(e => e.Title).HasName("PK__Descript__2CB664DDE63A44E5");

            entity.ToTable("Description");

            entity.Property(e => e.Title)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Descripe).IsUnicode(false);

            entity.HasOne(d => d.Game).WithMany(p => p.Descriptions)
                .HasForeignKey(d => d.GameId)
                .HasConstraintName("FK__Descripti__GameI__3C69FB99");
        });

        modelBuilder.Entity<Game>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Game__3214EC07A06C4BE9");

            entity.ToTable("Game");
        });

        modelBuilder.Entity<Leaderbord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Leaderbo__3214EC07981EC2D7");

            entity.ToTable("Leaderbord");

            entity.Property(e => e.Username)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.Game).WithMany(p => p.Leaderbords)
                .HasForeignKey(d => d.GameId)
                .HasConstraintName("FK__Leaderbor__GameI__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
