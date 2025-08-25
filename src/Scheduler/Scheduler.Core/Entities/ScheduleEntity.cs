namespace Scheduler.Core.Entities;

public class ScheduleEntity : BaseEntity
{
    public int GroupId { get; set; }
    public GroupEntity Group { get; set; }
    public ICollection<SchoolDayEntity> SchoolDays { get; set; }
}
