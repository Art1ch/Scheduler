using MediatR;
using Scheduler.Application.Requests.Faculty;
using Scheduler.Application.Responses.Faculty;

namespace Scheduler.Application.Queries.Faculty;

public sealed record GetFacultyWithGroupsQuery(
    GetFacultyWithGroupsRequest Request
) : IRequest<GetFacultyWithGroupsResponse>;

