using Scheduler.Core.Entities;

namespace Scheduler.Application.Contracts.Repositories;

public interface IScheduleRepository : IRepository<ScheduleEntity>
{
    Task<ScheduleEntity> GetWithGroupAsync(int id, CancellationToken cancellationToken = default);
    Task<ScheduleEntity> GetWithSchoolDaysAsync(int id, CancellationToken cancellationToken = default);
    Task<ScheduleEntity> GetFullAsync(int id, CancellationToken cancellationToken = default);
    Task<ScheduleEntity> GetByGroupIdAsync(int groupId, CancellationToken cancellationToken = default);
}
