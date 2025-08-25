using Scheduler.Core.Enums;

namespace Scheduler.Core.Entities;

public class SchoolDayEntity : BaseEntity
{
    public ICollection<LessonEntity> Lessons { get; set; }
    public WeekParity WeekParity { get; set; } 
    public DayOfWeek DayOfWeek { get; set; }
    public int ScheduleId { get; set; }
    public ScheduleEntity Schedule { get; set; }
}
