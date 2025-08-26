using MediatR;
using Scheduler.Application.Requests.SchoolDay;
using Scheduler.Application.Responses.SchoolDay;

namespace Scheduler.Application.Queries.SchoolDay;

public sealed record GetSchoolDayWithScheduleQuery(
    GetSchoolDayWithScheduleRequest Request
) : IRequest<GetSchoolDayWithScheduleResponse>;
