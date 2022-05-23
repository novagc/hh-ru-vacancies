using Microsoft.EntityFrameworkCore;

namespace HH.DB.Models
{
    public partial class HhContext : DbContext
    {
        private static string _connectionString;

        public HhContext()
        {
        }

        public HhContext(DbContextOptions<HhContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Area> Areas { get; set; } = null!;
        public virtual DbSet<Experience> Experiences { get; set; } = null!;
        public virtual DbSet<Skill> Skills { get; set; } = null!;
        public virtual DbSet<Specialization> Specializations { get; set; } = null!;
        public virtual DbSet<VacanciesSkill> VacanciesSkills { get; set; } = null!;
        public virtual DbSet<VacanciesSpecialization> VacanciesSpecializations { get; set; } = null!;
        public virtual DbSet<Vacancy> Vacancies { get; set; } = null!;

        public static void Init(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(_connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasKey(e => e.IdArea)
                    .HasName("Area_pkey");

                entity.ToTable("Area");

                entity.Property(e => e.IdArea).ValueGeneratedNever();
            });

            modelBuilder.Entity<Experience>(entity =>
            {
                entity.HasKey(e => e.IdExperience)
                    .HasName("Experience_pkey");

                entity.ToTable("Experience");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.HasKey(e => e.IdSkill)
                    .HasName("Skills_pkey");
            });

            modelBuilder.Entity<Specialization>(entity =>
            {
                entity.HasKey(e => e.IdSpecialization)
                    .HasName("Specializations_pkey");
            });

            modelBuilder.Entity<VacanciesSkill>(entity =>
            {
                entity.HasKey(x => new {x.IdVacancy, x.IdSkill}).HasName("VacanciesSkills_pkey");

                entity.HasIndex(e => e.IdSkill, "vacanciesskills_idskill_index");

                entity.HasIndex(e => e.IdVacancy, "vacanciesskills_idvacancy_index");

                entity.HasOne(d => d.IdSkillNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdSkill)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vacanciesskills_idskill_foreign");

                entity.HasOne(d => d.IdVacancyNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdVacancy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vacanciesskills_idvacancy_foreign");
            });

            modelBuilder.Entity<VacanciesSpecialization>(entity =>
            {
                entity.HasKey(x => new {x.IdVacancy, x.IdSpecialization}).HasName("VacanciesSpecializations_pkey");

                entity.HasIndex(e => e.IdSpecialization, "vacanciesspecializations_idspecialization_index");

                entity.HasIndex(e => e.IdVacancy, "vacanciesspecializations_idvacancy_index");

                entity.HasOne(d => d.IdSpecializationNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdSpecialization)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vacanciesspecializations_idspecialization_foreign");

                entity.HasOne(d => d.IdVacancyNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdVacancy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vacanciesspecializations_idvacancy_foreign");
            });

            modelBuilder.Entity<Vacancy>(entity =>
            {
                entity.HasKey(e => e.IdVacancy)
                    .HasName("Vacancies_pkey");

                entity.Property(e => e.IdVacancy).ValueGeneratedNever();

                entity.Property(e => e.PublishedAt).HasColumnType("timestamp(0) without time zone");

                entity.Property(e => e.SalaryFrom).HasPrecision(8, 2);

                entity.Property(e => e.SalaryTo).HasPrecision(8, 2);

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.Vacancies)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vacancies_idarea_foreign");

                entity.HasOne(d => d.IdExperienceNavigation)
                    .WithMany(p => p.Vacancies)
                    .HasForeignKey(d => d.IdExperience)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vacancies_idexperience_foreign");
            });

            modelBuilder.HasSequence("skill_id_seq").HasMin(0);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
