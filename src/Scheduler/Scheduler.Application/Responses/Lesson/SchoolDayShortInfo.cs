using Scheduler.Core.Enums;

namespace Scheduler.Application.Responses.Lesson;

public record SchoolDayShortInfo(
    int Id,
    DayOfWeek DayOfWeek,
    WeekParity WeekParity,
    int ScheduleId
);