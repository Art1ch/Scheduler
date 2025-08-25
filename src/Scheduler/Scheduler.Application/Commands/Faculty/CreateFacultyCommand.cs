using MediatR;
using Scheduler.Application.Requests.Faculty;

namespace Scheduler.Application.Commands.Faculty;

public sealed record CreateFacultyCommand(
    CreateFacultyRequest Request
) : IRequest<Unit>;