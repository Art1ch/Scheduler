using Microsoft.EntityFrameworkCore;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Core.Entities;
using Scheduler.Infrastructure.Context;

namespace Scheduler.Infrastructure.Repositories;

internal sealed class SchoolDayRepository : BaseRepository<SchoolDayEntity>, ISchoolDayRepository
{
    private readonly SchedulerContext _context;

    public SchoolDayRepository(SchedulerContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<SchoolDayEntity>> GetByScheduleIdAsync(int scheduleId, CancellationToken cancellationToken = default)
    {
        var schoolDays = await _context.SchoolDays
            .Where(x => x.ScheduleId == scheduleId)
            .AsNoTracking()
            .ToListAsync(cancellationToken);

        return schoolDays;
    }

    public async Task<IEnumerable<SchoolDayEntity>> GetFullAsync(int id, CancellationToken cancellationToken = default)
    {
        var schoolDays = await _context.SchoolDays
            .Where(x => x.Id == id)
            .AsNoTracking()
            .Include(x => x.Schedule)
            .Include(x => x.Lessons)
            .ToListAsync(cancellationToken);

        return schoolDays;
    }

    public async Task<SchoolDayEntity> GetWithLessonsAsync(int id, CancellationToken cancellationToken = default)
    {
        var schoolDay = await _context.SchoolDays
            .Where(x => x.Id == id)
            .AsNoTracking()
            .Include(x => x.Lessons)
            .FirstAsync(cancellationToken);

        return schoolDay;
    }

    public async Task<SchoolDayEntity> GetWithScheduleAsync(int id, CancellationToken cancellationToken = default)
    {
        var schoolDay = await _context.SchoolDays
            .Where(x => x.Id == id)
            .AsNoTracking()
            .Include(x => x.Schedule)
            .FirstAsync(cancellationToken);

        return schoolDay;
    }
}
