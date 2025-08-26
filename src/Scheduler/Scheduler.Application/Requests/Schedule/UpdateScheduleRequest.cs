namespace Scheduler.Application.Requests.Schedule;

public sealed record UpdateScheduleRequest(
    int Id,
    string Name,
    int GroupId,
    DateOnly StartDate,
    DateOnly EndDate
);
