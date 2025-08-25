namespace Scheduler.Application.Responses.Group;

public sealed record GetGroupWithFacultyResponse(
    int Id,
    string Name, 
    FacultyShortInfo Faculty
);
