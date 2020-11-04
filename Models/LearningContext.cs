using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApp_Rds_Access.Models
{
    public partial class LearningContext : DbContext
    {
        public LearningContext()
        {
        }

        public LearningContext(DbContextOptions<LearningContext> options)
            : base(options)
        {
        }

     /*   public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Enrollment> Enrollment { get; set; }
        public virtual DbSet<Login> Login { get; set; }*/
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<Resume> Resume { get; set; }

        /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
              if (!optionsBuilder.IsConfigured)
              {
  #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                  optionsBuilder.UseSqlServer("Data Source=sqlserver-comp306.cuhps7zqu8qb.us-east-1.rds.amazonaws.com,1433; database=SMS; User ID=admin; Password=akt1ehd2;");
              }
          }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.CourseCode)
                    .HasName("PK__Course__FC00E001003A999D");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CourseTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.School)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Enrollment>(entity =>
            {
                entity.HasKey(e => new { e.StudentId, e.CourseCode });

                entity.Property(e => e.StudentId)
                    .HasColumnName("StudentID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CourseCodeNavigation)
                    .WithMany(p => p.Enrollment)
                    .HasForeignKey(d => d.CourseCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Enrollment_Course");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Enrollment)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Enrollment_Student");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.LoginName)
                    .HasName("PK__Login__DB8464FEA86DD733");

                entity.Property(e => e.LoginName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.LoginNameNavigation)
                    .WithOne(p => p.Login)
                    .HasForeignKey<Login>(d => d.LoginName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Login_Student");
            });*/
            modelBuilder.Entity<LoginViewModel>(entity =>
            {
                entity.HasKey(e => e.Email)
                    .HasName("PK__Login__DB8464FEA86DD733");

                entity.Property(e => e.Email)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StudentPW)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.Property(e => e.StudentId)
                    .HasColumnName("StudentID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.StudentPW)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Teachers>(entity =>
            {
                entity.HasKey(e => e.TeacherId);

                entity.Property(e => e.TeacherId)
                    .HasColumnName("TeacherID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherPW)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
