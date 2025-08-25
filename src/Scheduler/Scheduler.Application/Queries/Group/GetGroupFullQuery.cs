using MediatR;
using Scheduler.Application.Responses.Group;

namespace Scheduler.Application.Queries.Group;

public record GetGroupFullQuery(
    int Id
) : IRequest<GetGroupFullResponse>;
