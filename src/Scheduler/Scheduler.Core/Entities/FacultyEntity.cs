namespace Scheduler.Core.Entities;

public class FacultyEntity : BaseEntity
{
    public string Name { get; set; }
    public ICollection<GroupEntity> Groups { get; set; }
}
