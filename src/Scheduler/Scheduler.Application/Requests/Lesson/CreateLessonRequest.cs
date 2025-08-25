namespace Scheduler.Application.Requests.Lesson;

public sealed record CreateLessonRequest(
    string Name,
    string AudienceNumber,
    TimeOnly StartTime,
    TimeOnly EndTime,
    int SchoolDayId
);