using Scheduler.Application.Responses.ShortInfos;

namespace Scheduler.Application.Responses.Schedule;

public sealed record GetScheduleFullResponse(
    int Id,
    string Name,
    DateOnly StartDate,
    DateOnly EndDate,
    List<SchoolDayShortInfo> SchoolDays,
    GroupShortInfo Group
);