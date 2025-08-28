using Scheduler.Application.Requests.SchoolDay;
using Scheduler.Application.Validation.Validators.Base;

namespace Scheduler.Application.Validation.Validators.SchoolDay;

public sealed class CreateSchoolDayRequestValidator : BaseSchoolDayValidator<CreateSchoolDayRequest>
{
    public CreateSchoolDayRequestValidator()
    {
        ValidateWeekParity(x => x.WeekParity);
        ValidateScheduleId(x => x.ScheduleId);
    }
}