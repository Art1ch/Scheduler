namespace Scheduler.Core.Entities;

public class GroupEntity : BaseEntity
{
    public string Name { get; set; }
    public int? FacultyId { get; set; }
    public FacultyEntity Faculty { get; set; }
    public int? ScheduleId { get; set; }
    public ScheduleEntity Schedule { get; set; }
}
