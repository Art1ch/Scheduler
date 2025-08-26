namespace Scheduler.Application.Responses.ShortInfos;

public sealed record LessonShortInfo(
    int Id,
    string Name,
    string AudienceNumber,
    TimeOnly StartTime,
    TimeOnly EndTime
);