using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonnelAdministrator.Domain;
using System;

namespace PersonnelAdministrator.Persistence.EntityTypeConfigurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Id).IsUnique();
            builder.Property(e => e.UserId).IsRequired(false);
            builder.Property(e => e.FistName).HasMaxLength(250).IsRequired(true);
            builder.Property(e => e.LastName).HasMaxLength(250).IsRequired(true);
            builder.Property(e => e.CreationDate).IsRequired(false).HasDefaultValue(DateTime.Now);
            builder.Property(e => e.EditDate).IsRequired(false).HasDefaultValue(DateTime.Now);
            builder.Property(e => e.LastChangeUserId).IsRequired(true);
        }
    }
}
