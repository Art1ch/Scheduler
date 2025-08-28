using Scheduler.Application.Requests.Faculty;
using Scheduler.Application.Validation.Validators.Base;

namespace Scheduler.Application.Validation.Validators.Faculty;

public sealed class CreateFacultyRequestValidator : BaseFacultyValidator<CreateFacultyRequest>
{
    public CreateFacultyRequestValidator()
    {
        ValidateFacultyName(x => x.Name);
    }
}
