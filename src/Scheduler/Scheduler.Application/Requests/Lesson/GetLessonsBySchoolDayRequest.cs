namespace Scheduler.Application.Requests.Lesson;

public sealed record GetLessonsBySchoolDayRequest(
    int SchoolDayId
);
