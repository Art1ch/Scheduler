using Scheduler.Application.Responses.ShortInfos;
using Scheduler.Core.Enums;

namespace Scheduler.Application.Responses.SchoolDay;

public sealed record GetSchoolDayWithScheduleResponse(
    int Id,
    WeekParity WeekParity,
    DayOfWeek DayOfWeek,
    ScheduleShortInfo ScheduleShortInfo
);

