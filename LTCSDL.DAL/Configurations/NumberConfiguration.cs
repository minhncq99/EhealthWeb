using LTCSDL.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LTCSDL.DAL.Configurations
{
    class NumberConfiguration : IEntityTypeConfiguration<Number>
    {
        public void Configure(EntityTypeBuilder<Number> builder)
        {
            builder.ToTable("Numbers");
            builder.HasKey(x => x.NumberId);

            builder.Property(x => x.NumberId).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired(true);

            builder.HasOne(n => n.Group).WithMany(g => g.Numbers).HasForeignKey(x => x.GroupId);
        }
    }
}
