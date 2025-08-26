using Scheduler.Core.Enums;

namespace Scheduler.Application.Responses.ShortInfos;

public record SchoolDayShortInfo(
    DayOfWeek DayOfWeek,
    WeekParity WeekParity,
    int ScheduleId
);