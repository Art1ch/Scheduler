namespace Scheduler.Core.Entities;

public class FacultyEntity : BaseEntity
{
    public string Name { get; set; }
    public IEnumerable<GroupEntity> Groups { get; set; }
}
