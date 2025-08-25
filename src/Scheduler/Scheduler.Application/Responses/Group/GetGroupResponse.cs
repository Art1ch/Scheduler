namespace Scheduler.Application.Responses.Group;

public sealed record GetGroupResponse(
    int Id,
    string Name
);