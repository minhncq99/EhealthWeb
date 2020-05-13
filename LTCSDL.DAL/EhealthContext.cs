using Microsoft.EntityFrameworkCore;
using LTCSDL.DAL.Models;
using LTCSDL.DAL.Configurations;
using LTCSDL.DAL.Extensions;

namespace LTCSDL.DAL
{
    ///Sử dụng migration (Tool -> Nuget Package Manager -> Package Manager Console)
    ///Bước 1
    ///Tạo mới migration: add-migration CreateCosmeticAppDB
    ///Bước 2
    ///Chuyển dữ liệu qua database: update-database –verbose
    public partial class EhealthContext : DbContext
    {
        public EhealthContext()
        {
        }
        public EhealthContext(DbContextOptions<EhealthContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=EhealthDB;Persist Security Info=True;User ID=sa;Password=123;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /**
             * Configuration with fluent API
             */
            modelBuilder.ApplyConfiguration(new ChapterConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new NumberConfiguration());
            modelBuilder.ApplyConfiguration(new DiseaseConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new Disease_UserConfiguration());

            /**
             * Data seeding 
             */
            modelBuilder.Seed();

            OnModelCreatingPartial(modelBuilder);
            //base.OnModelCreating(modelBuilder);
        }


        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Chapter> Chapters { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Group> Numbers { get; set; }
        public virtual DbSet<Disease>  Diseases { get; set; }
        public virtual DbSet<Disease_User> Diseases_Users { get; set; }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
