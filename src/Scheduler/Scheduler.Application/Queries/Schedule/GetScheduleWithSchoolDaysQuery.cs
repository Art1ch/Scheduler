using MediatR;
using Scheduler.Application.Requests.Schedule;
using Scheduler.Application.Responses.Schedule;

namespace Scheduler.Application.Queries.Schedule;

public sealed record GetScheduleWithSchoolDaysQuery(
    GetScheduleWithSchoolDaysRequest Request
) : IRequest<GetScheduleWithSchoolDaysResponse>;
