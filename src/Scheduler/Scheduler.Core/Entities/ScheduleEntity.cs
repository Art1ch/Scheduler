namespace Scheduler.Core.Entities;

public class ScheduleEntity : BaseEntity
{
    public string Name { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public int GroupId { get; set; }
    public GroupEntity Group { get; set; }
    public ICollection<SchoolDayEntity> SchoolDays { get; set; }
}
