using Microsoft.EntityFrameworkCore;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Core.Entities;
using Scheduler.Infrastructure.Context;

namespace Scheduler.Infrastructure.Repositories;

internal sealed class FacultyRepository : BaseRepository<FacultyEntity>, IFacultyRepository
{
    private readonly SchedulerContext _context;

    public FacultyRepository(SchedulerContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<FacultyEntity>> GetAllWithGroupsAsync(CancellationToken cancellationToken = default)
    {
        var facultiesWithGroups = await _context.Faculties
            .Include(x => x.Groups)
            .AsNoTracking()
            .ToListAsync(cancellationToken);

        return facultiesWithGroups;
    }

    public async Task<FacultyEntity> GetWithGroupsAsync(int id, CancellationToken cancellationToken = default)
    {
        var faculty = await _context.Faculties
            .Where(x => x.Id == id)
            .Include(x => x.Groups)
            .AsNoTracking()
            .FirstAsync(cancellationToken);

        return faculty;
    }
}