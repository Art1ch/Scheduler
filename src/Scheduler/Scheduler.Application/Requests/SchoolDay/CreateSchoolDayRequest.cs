using Scheduler.Core.Enums;

namespace Scheduler.Application.Requests.SchoolDay;

public sealed record CreateSchoolDayRequest(
    int ScheduleId,
    WeekParity WeekParity,
    DayOfWeek DayOfWeek
);
