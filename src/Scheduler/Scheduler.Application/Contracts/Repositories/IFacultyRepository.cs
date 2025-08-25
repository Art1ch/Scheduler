using Scheduler.Core.Entities;

namespace Scheduler.Application.Contracts.Repositories;

public interface IFacultyRepository : IRepository<FacultyEntity>
{
    Task<FacultyEntity> GetWithGroupsAsync(int id, CancellationToken cancellationToken = default);
    Task<IEnumerable<FacultyEntity>> GetAllWithGroupsAsync(CancellationToken cancellationToken = default);
}
