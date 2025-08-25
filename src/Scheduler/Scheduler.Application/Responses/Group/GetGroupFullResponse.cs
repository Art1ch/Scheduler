namespace Scheduler.Application.Responses.Group;

public record GetGroupFullResponse(
    int Id,
    string Name, 
    FacultyShortInfo Faculty,
    ScheduleShortInfo Schedule
);
