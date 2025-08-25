namespace Scheduler.Application.Requests.Lesson;

public sealed record UpdateLessonRequest(
    int Id,
    string Name,
    string AudienceNumber,
    TimeOnly StartTime,
    TimeOnly EndTime,
    int SchoolDayId
);
