using Microsoft.EntityFrameworkCore;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Core.Entities;
using Scheduler.Infrastructure.Context;

namespace Scheduler.Infrastructure.Repositories;

internal sealed class LessonRepository : BaseRepository<LessonEntity>, ILessonRepository
{
    private readonly SchedulerContext _context;

    public LessonRepository(SchedulerContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<LessonEntity>> GetBySchoolDayIdAsync(int schoolDayId, CancellationToken cancellationToken = default)
    {
        var lessons = await _context.Lessons
            .Where(x => x.SchoolDayId == schoolDayId)
            .AsNoTracking()
            .ToListAsync(cancellationToken);

        return lessons;
    }

    public async Task<LessonEntity> GetWithSchoolDayAsync(int id, CancellationToken cancellationToken = default)
    {
        var lesson = await _context.Lessons
            .Where(x => x.Id == id)
            .Include(x => x.SchoolDay)
            .AsNoTracking()
            .FirstAsync(cancellationToken);

        return lesson;
    }
}
