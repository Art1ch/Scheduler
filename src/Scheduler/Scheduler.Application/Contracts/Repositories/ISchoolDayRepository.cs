using Scheduler.Core.Entities;

namespace Scheduler.Application.Contracts.Repositories;

public interface ISchoolDayRepository : IRepository<SchoolDayEntity>
{
    Task<SchoolDayEntity> GetWithLessonsAsync(int id, CancellationToken cancellationToken = default);
    Task<SchoolDayEntity> GetWithScheduleAsync(int id, CancellationToken cancellationToken = default);
    Task<IEnumerable<SchoolDayEntity>> GetByScheduleIdAsync(int scheduleId, CancellationToken cancellationToken = default);
    Task<IEnumerable<SchoolDayEntity>> GetFullAsync(int id, CancellationToken cancellationToken = default);
}
