using FluentValidation;
using Scheduler.Application.Requests.Lesson;
using Scheduler.Application.Validation.Validators.Base;

namespace Scheduler.Application.Validation.Validators.Lesson;

public sealed class CreateBulkLessonsRequestValidator : BaseLessonValidator<CreateBulkLessonsRequest>
{
    public CreateBulkLessonsRequestValidator()
    {
        RuleFor(x => x.Lessons)
            .NotEmpty()
            .WithMessage("Как минимум 1 урок");

        RuleForEach(x => x.Lessons)
            .SetValidator(new CreateLessonRequestValidator());
    }
}
