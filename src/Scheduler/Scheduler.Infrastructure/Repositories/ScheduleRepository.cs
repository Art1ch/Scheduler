using Microsoft.EntityFrameworkCore;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Core.Entities;
using Scheduler.Infrastructure.Context;

namespace Scheduler.Infrastructure.Repositories;

internal sealed class ScheduleRepository : BaseRepository<ScheduleEntity>, IScheduleRepository
{
    private readonly SchedulerContext _context;

    public ScheduleRepository(SchedulerContext context) : base(context)
    {
        _context = context;
    }

    public async Task<ScheduleEntity> GetByGroupIdAsync(int groupId, CancellationToken cancellationToken = default)
    {
        var schedule = await _context.Schedules
            .Where(x => x.GroupId == groupId)
            .AsNoTracking()
            .FirstAsync(cancellationToken);

        return schedule;
    }

    public async Task<ScheduleEntity> GetFullAsync(int id, CancellationToken cancellationToken = default)
    {
        var schedule = await _context.Schedules
            .Where(x => x.Id == id)
            .AsNoTracking()
            .Include(x => x.SchoolDays)
            .Include(x => x.Group)
            .FirstAsync(cancellationToken);

        return schedule;
    }

    public async Task<ScheduleEntity> GetWithGroupAsync(int id, CancellationToken cancellationToken = default)
    {
        var schedule = await _context.Schedules
            .Where(x => x.Id == id)
            .AsNoTracking()
            .Include(x => x.Group)
            .FirstAsync(cancellationToken);

        return schedule;
    }

    public async Task<ScheduleEntity> GetWithSchoolDaysAsync(int id, CancellationToken cancellationToken = default)
    {
        var schedule = await _context.Schedules
            .Where(x => x.Id == id)
            .AsNoTracking()
            .Include(x => x.SchoolDays)
            .FirstAsync(cancellationToken);

        return schedule;
    }
}
