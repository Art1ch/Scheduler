using Scheduler.Application.Requests.Lesson;
using Scheduler.Application.Validation.Validators.Base;

namespace Scheduler.Application.Validation.Validators.Lesson;

public sealed class CreateLessonRequestValidator : BaseLessonValidator<CreateLessonRequest> 
{
    public CreateLessonRequestValidator()
    {
        ValidateLessonName(x => x.Name);
        ValidateLessonName(x => x.AudienceNumber);
        ValidateLessonTime(x => x.StartTime);
        ValidateLessonTime(x => x.EndTime);
        ValidateLessonTimeRange(x => x.StartTime, x => x.EndTime);
        ValidateSchoolDayId(x => x.SchoolDayId);
    }
}
