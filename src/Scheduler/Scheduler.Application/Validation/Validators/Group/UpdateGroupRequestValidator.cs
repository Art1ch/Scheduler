using Scheduler.Application.Requests.Group;
using Scheduler.Application.Validation.Validators.Base;

namespace Scheduler.Application.Validation.Validators.Group;

public sealed class UpdateGroupRequestValidator : BaseGroupValidator<UpdateGroupRequest>
{
    public UpdateGroupRequestValidator()
    {
        ValidateId(x => x.Id);
        ValidateGroupName(x => x.Name);
        ValidateFacultyId(x => x.FacultyId);
    }
}
