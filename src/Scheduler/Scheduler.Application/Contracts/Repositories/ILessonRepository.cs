using Scheduler.Core.Entities;

namespace Scheduler.Application.Contracts.Repositories;

public interface ILessonRepository : IRepository<LessonEntity>
{
    Task<LessonEntity> GetWithSchoolDayAsync(int id, CancellationToken cancellationToken = default);
    Task<IEnumerable<LessonEntity>> GetBySchoolDayIdAsync(int schoolDayId, CancellationToken cancellationToken = default);
}
