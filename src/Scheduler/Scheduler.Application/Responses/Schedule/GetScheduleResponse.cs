namespace Scheduler.Application.Responses.Schedule;

public sealed record GetScheduleResponse(
    int Id,
    string Name,
    DateOnly StartDate,
    DateOnly EndDate
);