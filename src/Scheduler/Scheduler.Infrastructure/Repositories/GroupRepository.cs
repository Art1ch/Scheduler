using Microsoft.EntityFrameworkCore;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Core.Entities;
using Scheduler.Infrastructure.Context;

namespace Scheduler.Infrastructure.Repositories;

internal sealed class GroupRepository : BaseRepository<GroupEntity>, IGroupRepository
{
    private readonly SchedulerContext _context;

    public GroupRepository(SchedulerContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<GroupEntity>> GetAllGroupsByFacultyId(int facultyId, CancellationToken cancellationToken = default)
    {
        var groups = await _context.Groups
            .Where(x => x.FacultyId == facultyId)
            .AsNoTracking()
            .ToListAsync(cancellationToken);

        return groups;
    }

    public async Task<GroupEntity> GetFullAsync(int id, CancellationToken cancellationToken = default)
    {
        var group = await _context.Groups
            .Where(x => x.Id == id)
            .Include(x => x.Faculty)
            .Include(x => x.Schedule)
            .AsNoTracking()
            .FirstAsync(cancellationToken);

        return group;
    }

    public async Task<GroupEntity> GetWithFacultyAsync(int id, CancellationToken cancellationToken = default)
    {
        var group = await _context.Groups
            .Where(x => x.Id == id)
            .Include(x => x.Faculty)
            .AsNoTracking()
            .FirstAsync(cancellationToken);

        return group;
    }

    public async Task<GroupEntity> GetWithScheduleAsync(int id, CancellationToken cancellationToken = default)
    {
        var group = await _context.Groups
            .Where(x => x.Id == id)
            .Include(x => x.Schedule)
            .AsNoTracking()
            .FirstAsync(cancellationToken);

        return group;
    }
}
