using LTCSDL.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LTCSDL.DAL.Configurations
{
    public class Disease_UserConfiguration : IEntityTypeConfiguration<Disease_User>
    {
        public void Configure(EntityTypeBuilder<Disease_User> builder)
        {
            builder.ToTable("Diseases_Users");
            builder.HasKey(x => new { x.DiseaseId, x.UserId });

            builder.HasOne(d => d.Disease).WithMany(du => du.Diseases_Users).HasForeignKey(x => x.DiseaseId);
            builder.HasOne(u => u.User).WithMany(du => du.Diseases_Users).HasForeignKey(x => x.UserId);
        }
    }
}
