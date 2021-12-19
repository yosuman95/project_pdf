using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PdfiumViewer.Demo
{
    public partial class booksdbstoreContext : DbContext
    {
        public booksdbstoreContext()
        {
        }

        public booksdbstoreContext(DbContextOptions<booksdbstoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Kafedratable> Kafedratable { get; set; }
        public virtual DbSet<Razdeltable> Razdeltable { get; set; }
        public virtual DbSet<Sourcetable> Sourcetable { get; set; }
        public virtual DbSet<Subjecttable> Subjecttable { get; set; }
        public virtual DbSet<WorkTable> WorkTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server= WIN-6V9F9H9O076\\SQLEXPRESS;Database=booksdbstore;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kafedratable>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KafName).HasMaxLength(50);
            });

            modelBuilder.Entity<Razdeltable>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdSubject).HasColumnName("idSubject");

                entity.Property(e => e.PartName).HasMaxLength(100);

                entity.HasOne(d => d.IdSubjectNavigation)
                    .WithMany(p => p.Razdeltable)
                    .HasForeignKey(d => d.IdSubject)
                    .HasConstraintName("FK_Razdeltable_Subjecttable");
            });

            modelBuilder.Entity<Sourcetable>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdRazdel).HasColumnName("idRazdel");

                entity.Property(e => e.IdWork).HasColumnName("idWork");

                entity.HasOne(d => d.IdRazdelNavigation)
                    .WithMany(p => p.Sourcetable)
                    .HasForeignKey(d => d.IdRazdel)
                    .HasConstraintName("FK_Sourcetable_Razdeltable");

                entity.HasOne(d => d.IdWorkNavigation)
                    .WithMany(p => p.Sourcetable)
                    .HasForeignKey(d => d.IdWork)
                    .HasConstraintName("FK_Sourcetable_WorkTable");
            });

            modelBuilder.Entity<Subjecttable>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Author)
                    .HasColumnName("author")
                    .HasMaxLength(50);

                entity.Property(e => e.SubjectName).HasMaxLength(50);

                entity.HasOne(d => d.IdKafNavigation)
                    .WithMany(p => p.Subjecttable)
                    .HasForeignKey(d => d.IdKaf)
                    .HasConstraintName("FK_Subjecttable_Kafedratable");
            });

            modelBuilder.Entity<WorkTable>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.WorkName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
