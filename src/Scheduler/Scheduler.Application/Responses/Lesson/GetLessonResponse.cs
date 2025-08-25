namespace Scheduler.Application.Responses.Lesson;

public sealed record GetLessonResponse(
    int Id,
    string Name,
    string AudienceNumber,
    TimeOnly StartTime,
    TimeOnly EndTime,
    int SchoolDayId
);
