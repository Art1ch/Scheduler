using MediatR;
using Scheduler.Application.Requests.Schedule;
using Scheduler.Application.Responses.Schedule;

namespace Scheduler.Application.Queries.Schedule;

public sealed record GetScheduleWithGroupQuery(
    GetScheduleWithGroupRequest Request
) : IRequest<GetScheduleWithGroupResponse>;
