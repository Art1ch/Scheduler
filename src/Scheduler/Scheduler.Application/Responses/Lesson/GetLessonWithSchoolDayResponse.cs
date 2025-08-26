using Scheduler.Application.Responses.ShortInfos;
using Scheduler.Core.Enums;

namespace Scheduler.Application.Responses.Lesson;

public record GetLessonWithSchoolDayResponse(
    int Id,
    string Name,
    string AudienceNumber,
    TimeOnly StartTime,
    TimeOnly EndTime,
    WeekParity WeekParity,
    SchoolDayShortInfo SchoolDay
);
