namespace Scheduler.Application.Requests.Group;

public sealed record CreateGroupRequest(
    string Name,
    int FacultyId
);
