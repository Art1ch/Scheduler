namespace Scheduler.Application.Requests.Lesson;

public sealed record CreateBulkLessonsRequest(
    List<CreateLessonRequest> Lessons    
);
