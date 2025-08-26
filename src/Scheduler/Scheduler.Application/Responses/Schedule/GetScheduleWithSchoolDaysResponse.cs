using Scheduler.Application.Responses.ShortInfos;

namespace Scheduler.Application.Responses.Schedule;

public sealed record GetScheduleWithSchoolDaysResponse(
    int Id,
    string Name,
    DateOnly StartDate,
    DateOnly EndDate,
    List<SchoolDayShortInfo> SchoolDays
);
