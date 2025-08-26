using Scheduler.Application.Responses.ShortInfos;
using Scheduler.Core.Enums;

namespace Scheduler.Application.Responses.SchoolDay;

public sealed record GetSchoolDayFullResponse(
    int Id,
    WeekParity WeekParity,
    DayOfWeek DayOfWeek,
    List<LessonShortInfo> Lessons,
    ScheduleShortInfo Schedule
);

