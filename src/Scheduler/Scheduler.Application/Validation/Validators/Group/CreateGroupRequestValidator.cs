using Scheduler.Application.Requests.Group;
using Scheduler.Application.Validation.Validators.Base;

namespace Scheduler.Application.Validation.Validators.Group;

public sealed class CreateGroupRequestValidator : BaseGroupValidator<CreateGroupRequest>
{
    public CreateGroupRequestValidator()
    {
        ValidateGroupName(x => x.Name);
        ValidateFacultyId(x => x.FacultyId);
    }
}
