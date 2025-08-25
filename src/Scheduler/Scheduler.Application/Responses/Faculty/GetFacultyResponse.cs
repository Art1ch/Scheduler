namespace Scheduler.Application.Responses.Faculty;

public sealed record GetFacultyResponse(
    int Id,
    string Name,
    int GroupCount
);
