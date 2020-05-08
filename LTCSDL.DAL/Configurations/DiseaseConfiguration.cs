using LTCSDL.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LTCSDL.DAL.Configurations
{
    public class DiseaseConfiguration : IEntityTypeConfiguration<Disease>
    {
        public void Configure(EntityTypeBuilder<Disease> builder)
        {
            builder.ToTable("Diseases");
            builder.HasKey(x => x.DiseaseId);

            builder.Property(x => x.DiseaseId).ValueGeneratedOnAdd();
            builder.Property(x =>x.EnglishName).IsRequired(true);
            builder.Property(x => x.VietnameseName).IsRequired(true);
            builder.Property(x => x.Symptom).IsRequired(true);

            builder.HasOne(d => d.Number).WithMany(n => n.Diseases).HasForeignKey(x => x.NumberId);
        }
    }
}
