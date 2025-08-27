using Microsoft.EntityFrameworkCore;
using Scheduler.Core.Entities;

namespace Scheduler.Infrastructure.Context;

internal sealed class SchedulerContext : DbContext
{
    public SchedulerContext(DbContextOptions<SchedulerContext> options) : base(options) { }

    public DbSet<FacultyEntity> Faculties { get; set; }
    public DbSet<GroupEntity> Groups { get; set; }
    public DbSet<LessonEntity> Lessons { get; set; }
    public DbSet<ScheduleEntity> Schedules { get; set; }
    public DbSet<SchoolDayEntity> SchoolDays { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ConfigureFaculty()
            .ConfigureGroup()
            .ConfigureLesson()
            .ConfigureSchedule()
            .ConfigureSchoolDay();
    }
}