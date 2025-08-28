namespace Scheduler.Application.Validation.Constants;

public static class LessonConstants
{
    public const int NameMinLength = 2;
    public const int NameMaxLength = 20;

    public const int AudienceNumberMinLength = 3;
    public const int AudienceNumberMaxLength = 10;

    public static readonly TimeOnly EarliestStartTime = new(7, 0);
    public static readonly TimeOnly LatestEndTime = new(22, 0);
}
