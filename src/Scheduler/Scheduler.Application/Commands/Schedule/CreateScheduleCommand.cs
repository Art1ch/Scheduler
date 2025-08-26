using MediatR;
using Scheduler.Application.Requests.Schedule;

namespace Scheduler.Application.Commands.Schedule;

public sealed record CreateScheduleCommand(
    CreateScheduleRequest Request
) : IRequest<Unit>;
