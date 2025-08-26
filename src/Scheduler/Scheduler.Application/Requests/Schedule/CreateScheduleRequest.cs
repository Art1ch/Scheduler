namespace Scheduler.Application.Requests.Schedule;

public sealed record CreateScheduleRequest(
    string Name,
    int GroupId,
    DateOnly StartDate,
    DateOnly EndDate
);