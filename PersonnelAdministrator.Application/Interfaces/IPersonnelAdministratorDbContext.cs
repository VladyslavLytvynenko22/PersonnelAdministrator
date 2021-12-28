using Microsoft.EntityFrameworkCore;
using PersonnelAdministrator.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace PersonnelAdministrator.Application.Interfaces
{
    public interface IPersonnelAdministratorDbContext
    {
        DbSet<Employee> Employee { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
