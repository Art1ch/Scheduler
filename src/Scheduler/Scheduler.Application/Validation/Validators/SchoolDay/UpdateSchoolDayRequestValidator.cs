using Scheduler.Application.Requests.SchoolDay;
using Scheduler.Application.Validation.Validators.Base;

namespace Scheduler.Application.Validation.Validators.SchoolDay;

public sealed class UpdateSchoolDayRequestValidator : BaseSchoolDayValidator<UpdateSchoolDayRequest>
{
    public UpdateSchoolDayRequestValidator()
    {
        ValidateId(x => x.Id);
        ValidateWeekParity(x => x.WeekParity);
        ValidateScheduleId(x => x.ScheduleId);
    }
}
