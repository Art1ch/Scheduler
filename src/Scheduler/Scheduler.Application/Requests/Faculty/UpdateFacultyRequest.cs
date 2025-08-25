namespace Scheduler.Application.Requests.Faculty;

public sealed record UpdateFacultyRequest(
    int Id,
    string Name
);
