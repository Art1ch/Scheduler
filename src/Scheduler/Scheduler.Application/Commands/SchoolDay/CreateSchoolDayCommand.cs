using MediatR;
using Scheduler.Application.Requests.SchoolDay;

namespace Scheduler.Application.Commands.SchoolDay;

public sealed record CreateSchoolDayCommand(
    CreateSchoolDayRequest Request    
) : IRequest<Unit>;