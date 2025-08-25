using MediatR;
using Scheduler.Application.Requests.Group;
using Scheduler.Application.Responses.Group;

namespace Scheduler.Application.Queries.Group;

public record GetGroupsByFacultyQuery(
    GetGroupsByFacultyRequest Request
) : IRequest<IEnumerable<GetGroupResponse>>;