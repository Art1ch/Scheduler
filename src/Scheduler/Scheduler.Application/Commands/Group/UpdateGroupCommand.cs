using MediatR;
using Scheduler.Application.Requests.Group;

namespace Scheduler.Application.Commands.Group;

public sealed record UpdateGroupCommand(
    UpdateGroupRequest Request
) : IRequest<Unit>;
