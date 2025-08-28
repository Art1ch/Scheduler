using Scheduler.Application.Requests.Faculty;
using Scheduler.Application.Validation.Validators.Base;

namespace Scheduler.Application.Validation.Validators.Faculty;

public sealed class UpdateFacultyRequestValidator : BaseFacultyValidator<UpdateFacultyRequest>
{
    public UpdateFacultyRequestValidator()
    {
        ValidateId(x => x.Id);
        ValidateFacultyName(x => x.Name);
    }
}