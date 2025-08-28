using Scheduler.Application.Requests.Schedule;
using Scheduler.Application.Validation.Validators.Base;

namespace Scheduler.Application.Validation.Validators.Schedule;

public sealed class CreateScheduleRequestValidator : BaseScheduleValidator<CreateScheduleRequest>
{
    public CreateScheduleRequestValidator()
    {
        ValidateScheduleName(x => x.Name);
        ValidateGroupId(x => x.GroupId);
        ValidateStartDate(x => x.StartDate);
        ValidateEndDate(x => x.EndDate);
        ValidateDateRange(x => x.StartDate, x => x.EndDate);
        ValidateGroupId(x => x.GroupId);
    }
}
