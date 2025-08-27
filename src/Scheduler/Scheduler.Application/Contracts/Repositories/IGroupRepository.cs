using Scheduler.Core.Entities;

namespace Scheduler.Application.Contracts.Repositories;

public interface IGroupRepository : IRepository<GroupEntity>
{
    Task<GroupEntity> GetWithFacultyAsync(int id, CancellationToken cancellationToken = default);
    Task<GroupEntity> GetWithScheduleAsync(int id, CancellationToken cancellationToken = default);
    Task<GroupEntity> GetFullAsync(int id, CancellationToken cancellationToken = default);
    Task<IEnumerable<GroupEntity>> GetAllGroupsByFacultyId(int facultyId, CancellationToken cancellationToken = default);
}