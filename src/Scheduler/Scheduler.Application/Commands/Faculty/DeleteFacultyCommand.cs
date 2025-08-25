using MediatR;
using Scheduler.Application.Requests.Faculty;

namespace Scheduler.Application.Commands.Faculty;

public sealed record DeleteFacultyCommand(
    DeleteFacultyRequest Request
): IRequest<Unit>;
