namespace Scheduler.Application.Validation.Constants;

public static class ScheduleConstants
{
    public const int NameMinLength = 2;
    public const int NameMaxLength = 100;

    public static readonly DateOnly MinStartDate = new(2020, 1, 1);
    public static readonly DateOnly MaxEndDate = new(2100, 12, 31);
}