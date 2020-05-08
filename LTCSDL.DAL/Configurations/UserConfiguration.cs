using LTCSDL.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LTCSDL.DAL.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.UserId);

            builder.Property(x => x.UserId).ValueGeneratedOnAdd();
            builder.Property(x => x.FullName).IsRequired(true);
            builder.Property(x => x.UserName).IsRequired(true);
            builder.Property(x => x.Password).IsRequired(true);
            builder.Property(x => x.Email).IsRequired(true);
            builder.Property(x => x.Job).IsRequired(true);
            builder.Property(x => x.TypeUser).IsRequired(true);
        }   
    }
}
