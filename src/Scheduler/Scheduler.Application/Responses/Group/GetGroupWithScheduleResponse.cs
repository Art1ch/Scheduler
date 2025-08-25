namespace Scheduler.Application.Responses.Group;

public sealed record GetGroupWithScheduleResponse(
    int Id,
    string Name,
    ScheduleShortInfo Schedule
);
