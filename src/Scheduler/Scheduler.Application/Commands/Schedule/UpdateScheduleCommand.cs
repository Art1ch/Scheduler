using MediatR;
using Scheduler.Application.Requests.Schedule;

namespace Scheduler.Application.Commands.Schedule;

public sealed record UpdateScheduleCommand(
    UpdateScheduleRequest Request
) : IRequest<Unit>;

