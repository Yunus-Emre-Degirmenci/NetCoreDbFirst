using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CinemaDbFirst.Models
{
    public partial class CinemaDBContext : DbContext
    {
        public CinemaDBContext()
        {
        }

        public CinemaDBContext(DbContextOptions<CinemaDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblActor> TblActors { get; set; }
        public virtual DbSet<TblCategory> TblCategories { get; set; }
        public virtual DbSet<TblDirector> TblDirectors { get; set; }
        public virtual DbSet<TblMovie> TblMovies { get; set; }
        public virtual DbSet<TblMovieActor> TblMovieActors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=CinemaDB;uid=sa;pwd=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<TblActor>(entity =>
            {
                entity.ToTable("Tbl_Actors");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActorName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.ToTable("Tbl_Categories");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblDirector>(entity =>
            {
                entity.ToTable("Tbl_Directors");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DirectorName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblMovie>(entity =>
            {
                entity.ToTable("Tbl_Movies");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(300);

                entity.Property(e => e.DirectorId).HasColumnName("DirectorID");

                entity.Property(e => e.MovieName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblMovies)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Movies_Tbl_Categories");

                entity.HasOne(d => d.Director)
                    .WithMany(p => p.TblMovies)
                    .HasForeignKey(d => d.DirectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Movies_Tbl_Directors");
            });

            modelBuilder.Entity<TblMovieActor>(entity =>
            {
                entity.HasKey(e => new { e.MovieId, e.ActorId });

                entity.ToTable("Tbl_MovieActors");

                entity.Property(e => e.MovieId).HasColumnName("MovieID");

                entity.Property(e => e.ActorId).HasColumnName("ActorID");

                entity.HasOne(d => d.Actor)
                    .WithMany(p => p.TblMovieActors)
                    .HasForeignKey(d => d.ActorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_MovieActors_Tbl_Actors");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.TblMovieActors)
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_MovieActors_Tbl_Movies");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
