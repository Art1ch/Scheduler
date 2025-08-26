using Scheduler.Application.Responses.ShortInfos;

namespace Scheduler.Application.Responses.Schedule;

public sealed record GetScheduleWithGroupResponse(
    int Id,
    string Name,
    DateOnly StartDate,
    DateOnly EndDate,
    GroupShortInfo Group
);
