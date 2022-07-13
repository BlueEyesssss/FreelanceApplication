using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BusinessObject
{
    public partial class FreelanceWinFormContext : DbContext
    {
        public FreelanceWinFormContext()
        {
        }

        public FreelanceWinFormContext(DbContextOptions<FreelanceWinFormContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HasSkill> HasSkills { get; set; }
        public virtual DbSet<Hirer> Hirers { get; set; }
        public virtual DbSet<NeededSkill> NeededSkills { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Proposal> Proposals { get; set; }
        public virtual DbSet<Seeker> Seekers { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);Uid=sa;Pwd=1234567890;Database=FreelanceWinForm");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<HasSkill>(entity =>
            {
                entity.ToTable("HasSkill");

                entity.Property(e => e.HasSkillId).HasColumnName("hasSkillID");

                entity.Property(e => e.SeekerId).HasColumnName("seekerID");

                entity.Property(e => e.SkillId).HasColumnName("skillID");

                entity.HasOne(d => d.Seeker)
                    .WithMany(p => p.HasSkills)
                    .HasForeignKey(d => d.SeekerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("HasSkill_Seeker");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.HasSkills)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("HasSkill_Skill");
            });

            modelBuilder.Entity<Hirer>(entity =>
            {
                entity.ToTable("Hirer");

                entity.Property(e => e.HirerId)
                    .ValueGeneratedNever()
                    .HasColumnName("hirerID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .HasColumnName("companyName");

                entity.HasOne(d => d.HirerNavigation)
                    .WithOne(p => p.Hirer)
                    .HasForeignKey<Hirer>(d => d.HirerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Hirer_User");
            });

            modelBuilder.Entity<NeededSkill>(entity =>
            {
                entity.HasKey(e => e.NeededSkillsId)
                    .HasName("NeededSkills_pk");

                entity.Property(e => e.NeededSkillsId).HasColumnName("neededSkillsID");

                entity.Property(e => e.ProjectId).HasColumnName("projectID");

                entity.Property(e => e.SkillId).HasColumnName("skillID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.NeededSkills)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("NeededSkills_Project");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.NeededSkills)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("NeededSkills_Skill");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Project");

                entity.Property(e => e.ProjectId).HasColumnName("projectID");

                entity.Property(e => e.Complexity)
                    .HasMaxLength(128)
                    .HasColumnName("complexity");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("createdDate");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.ExpectedDuration)
                    .HasMaxLength(100)
                    .HasColumnName("expectedDuration");

                entity.Property(e => e.HirerId).HasColumnName("hirerID");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .HasColumnName("location");

                entity.Property(e => e.Major)
                    .HasMaxLength(50)
                    .HasColumnName("major");

                entity.Property(e => e.PaymentAmount)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("paymentAmount");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("projectName");

                entity.HasOne(d => d.Hirer)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.HirerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Project_Hirer");
            });

            modelBuilder.Entity<Proposal>(entity =>
            {
                entity.ToTable("Proposal");

                entity.Property(e => e.ProposalId).HasColumnName("proposalID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("createdDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PaymentAmount)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("paymentAmount");

                entity.Property(e => e.ProjectId).HasColumnName("projectID");

                entity.Property(e => e.SeekerId).HasColumnName("seekerID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Proposals)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Proposal_Project");

                entity.HasOne(d => d.Seeker)
                    .WithMany(p => p.Proposals)
                    .HasForeignKey(d => d.SeekerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Proposal_Seeker");
            });

            modelBuilder.Entity<Seeker>(entity =>
            {
                entity.ToTable("Seeker");

                entity.Property(e => e.SeekerId)
                    .ValueGeneratedNever()
                    .HasColumnName("seekerID");

                entity.Property(e => e.Major)
                    .HasMaxLength(100)
                    .HasColumnName("major");

                entity.Property(e => e.Overview)
                    .HasMaxLength(255)
                    .HasColumnName("overview");

                entity.Property(e => e.School)
                    .HasMaxLength(100)
                    .HasColumnName("school");

                entity.HasOne(d => d.SeekerNavigation)
                    .WithOne(p => p.Seeker)
                    .HasForeignKey<Seeker>(d => d.SeekerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Seeker_User");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("Skill");

                entity.Property(e => e.SkillId).HasColumnName("skillID");

                entity.Property(e => e.SkillName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("skillName");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.HasIndex(e => e.UserName, "UQ__User__66DCF95C3546C6A3")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.Balance)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("balance");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .HasColumnName("fullName");

                entity.Property(e => e.Location)
                    .HasMaxLength(255)
                    .HasColumnName("location");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .HasColumnName("phone");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("userName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
