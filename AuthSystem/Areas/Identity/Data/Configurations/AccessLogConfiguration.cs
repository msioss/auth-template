using AuthSystem.Areas.Identity.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuthSystem.Areas.Identity.Data.Configurations;

public class AccessLogConfiguration : IEntityTypeConfiguration<AccessLog>
{
    public void Configure(EntityTypeBuilder<AccessLog> builder)
    {
        builder.HasKey(u => u.Id);

        builder.HasOne(p => p.User).WithMany(u => u.AccessLogs)
            .HasForeignKey(x => x.UserId);
    }
}