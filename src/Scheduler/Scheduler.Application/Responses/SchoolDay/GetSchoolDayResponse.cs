using Scheduler.Core.Enums;

namespace Scheduler.Application.Responses.SchoolDay;

public sealed record GetSchoolDayResponse(
    int Id,
    WeekParity WeekParity,
    DayOfWeek DayOfWeek
);