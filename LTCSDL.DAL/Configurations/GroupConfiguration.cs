using LTCSDL.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LTCSDL.DAL.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.ToTable("Groups");
            builder.HasKey(x => x.GroupId);

            builder.Property(x => x.GroupId).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired(true);

            builder.HasOne(g => g.Chapter).WithMany(c => c.Groups).HasForeignKey(x => x.ChapterId);
        }
    }
}
