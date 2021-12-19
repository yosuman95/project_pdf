using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PdfiumViewer.Demo
{
    public partial class StudentsDBContext : DbContext
    {
        public StudentsDBContext()
        {
        }

        public StudentsDBContext(DbContextOptions<StudentsDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Mark> Mark { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentFile> StudentFile { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server= WIN-6V9F9H9O076\\SQLEXPRESS;Database=StudentsDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>(entity =>
            {
                entity.Property(e => e.Chipher).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Profile).HasMaxLength(50);
            });

            modelBuilder.Entity<Mark>(entity =>
            {
                entity.Property(e => e.CountOfPasses).HasDefaultValueSql("((0))");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Mark)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_MarksTable_StudentsTable");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.BirthDay).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(1);

                entity.Property(e => e.IsSary).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.StartCourse).HasColumnType("date");

                entity.Property(e => e.Telephon).HasMaxLength(25);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_StudentsTable_GroupsTable");
            });

            modelBuilder.Entity<StudentFile>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK_FilesTable");

                entity.Property(e => e.CountOfPassesWithArespectful)
                    .HasColumnName("CountOfPassesWithARespectful")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DataReceptFile).HasColumnType("date");

                entity.Property(e => e.FileName).HasMaxLength(150);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentFile)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_FilesTable_StudentsTable");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
