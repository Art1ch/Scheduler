using MediatR;
using Scheduler.Application.Requests.SchoolDay;

namespace Scheduler.Application.Commands.SchoolDay;

public sealed record UpdateSchoolDayCommand(
    UpdateSchoolDayRequest Request
) : IRequest<Unit>;
