namespace Scheduler.Core.Entities;

public class LessonEntity : BaseEntity
{
    public string Name { get; set; }
    public IEnumerable<LessonEntity> Lessons { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
}
