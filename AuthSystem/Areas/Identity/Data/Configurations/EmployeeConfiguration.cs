using AuthSystem.Areas.Identity.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuthSystem.Areas.Identity.Data.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasKey(u => u.Id);
        builder.HasIndex(u => u.Inn).IsUnique();

        builder.HasOne(p => p.Post).WithMany(u => u.Employees)
            .HasForeignKey(x => x.PostId).IsRequired(false);
        builder.HasOne(p => p.EmployeeProfile).WithOne(u => u.Employee)
            .HasForeignKey<EmployeeProfile>(x => x.Id);

        builder.HasMany(p => p.MilitaryRegistrations).WithOne(u => u.Employee)
            .HasForeignKey(x => x.EmployeeId);
        builder.HasMany(p => p.Vacations).WithOne(u => u.Employee)
            .HasForeignKey(x => x.EmployeeId);
        builder.HasMany(p => p.WorkHours).WithOne(u => u.Employee)
            .HasForeignKey(x => x.EmployeeId);
    }
}