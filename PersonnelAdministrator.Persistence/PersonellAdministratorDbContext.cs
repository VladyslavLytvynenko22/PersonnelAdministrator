using Microsoft.EntityFrameworkCore;
using PersonnelAdministrator.Application.Interfaces;
using PersonnelAdministrator.Domain;
using PersonnelAdministrator.Persistence.EntityTypeConfigurations;

namespace PersonnelAdministrator.Persistence
{
    public class PersonellAdministratorDbContext : DbContext, IPersonnelAdministratorDbContext
    {
        public DbSet<Employee> Employee { get; set; }

        public PersonellAdministratorDbContext(DbContextOptions<PersonellAdministratorDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EmployeeConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
