using LTCSDL.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LTCSDL.DAL.Configurations
{
    public class ChapterConfiguration : IEntityTypeConfiguration<Chapter>
    {
        public void Configure(EntityTypeBuilder<Chapter> builder)
        {
            builder.ToTable("Chapters");
            builder.HasKey(x => x.ChapterId);

            builder.Property(x => x.ChapterId).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired(true);
        }
    }
}
