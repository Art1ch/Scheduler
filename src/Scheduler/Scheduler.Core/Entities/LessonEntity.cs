namespace Scheduler.Core.Entities;


public class LessonEntity : BaseEntity
{
    public string Name { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public int SchoolDayId { get; set; }
    public SchoolDayEntity SchoolDay { get; set; }
}
