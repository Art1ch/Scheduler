using Scheduler.Core.Enums;

namespace Scheduler.Application.Requests.SchoolDay;

public sealed record UpdateSchoolDayRequest(
    int Id,
    int ScheduleId,
    WeekParity WeekParity,
    DayOfWeek DayOfWeek
);
