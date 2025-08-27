using Microsoft.EntityFrameworkCore;
using Scheduler.Core.Entities;

namespace Scheduler.Infrastructure.Context;

internal static class ModelBuilderExtensions
{
    public static ModelBuilder ConfigureFaculty(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FacultyEntity>(entity =>
        {
            entity.HasKey(x => x.Id);

            entity
                .HasMany(x => x.Groups)
                .WithOne(x => x.Faculty)
                .HasForeignKey(x => x.FacultyId)
                .OnDelete(DeleteBehavior.Cascade); 
        });

        return modelBuilder;
    }

    public static ModelBuilder ConfigureGroup(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GroupEntity>(entity =>
        {
            entity.HasKey(x => x.Id);

            entity
                .HasOne(x => x.Schedule)
                .WithOne(x => x.Group)
                .HasForeignKey<GroupEntity>(x => x.ScheduleId)
                .OnDelete(DeleteBehavior.Cascade); 
        });

        return modelBuilder;
    }

    public static ModelBuilder ConfigureSchedule(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ScheduleEntity>(entity =>
        {
            entity.HasKey(x => x.Id);

            entity
                .HasMany(x => x.SchoolDays)
                .WithOne(x => x.Schedule)
                .HasForeignKey(x => x.ScheduleId)
                .OnDelete(DeleteBehavior.Cascade);

            entity
                .HasOne(x => x.Group)
                .WithOne(x => x.Schedule)
                .HasForeignKey<ScheduleEntity>(x => x.GroupId)
                .OnDelete(DeleteBehavior.Restrict); 
        });

        return modelBuilder;
    }

    public static ModelBuilder ConfigureLesson(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LessonEntity>(entity =>
        {
            entity.HasKey(x => x.Id);

            entity
                .HasOne(x => x.SchoolDay)
                .WithMany(x => x.Lessons)
                .HasForeignKey(x => x.SchoolDayId)
                .OnDelete(DeleteBehavior.Cascade); 
        });

        return modelBuilder;
    }

    public static ModelBuilder ConfigureSchoolDay(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SchoolDayEntity>(entity =>
        {
            entity.HasKey(x => x.Id);

            entity
                .HasOne(x => x.Schedule)
                .WithMany(x => x.SchoolDays)
                .HasForeignKey(x => x.ScheduleId)
                .OnDelete(DeleteBehavior.Restrict); 
        });

        return modelBuilder;
    }
}