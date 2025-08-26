using Scheduler.Application.Responses.ShortInfos;

namespace Scheduler.Application.Responses.Faculty;

public sealed record GetFacultyWithGroupsResponse(
    int Id,
    string Name,
    ICollection<GroupShortInfo> Groups    
);
