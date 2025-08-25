using MediatR;
using Scheduler.Application.Responses.Group;

namespace Scheduler.Application.Queries.Group;

public record GetGroupQuery(
    int Id
) : IRequest<GetGroupResponse>;