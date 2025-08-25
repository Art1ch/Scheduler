namespace Scheduler.Application.Requests.Group;

public sealed record UpdateGroupRequest(
    int Id,
    string Name,
    int FacultyId
);
