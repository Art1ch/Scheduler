using FluentValidation;
using Scheduler.Application.Validation.Constants;
using System.Linq.Expressions;

namespace Scheduler.Application.Validation.Validators.Base;

public abstract class BaseScheduleValidator<T> : AbstractValidator<T>
{
    protected void ValidateId(Expression<Func<T, int>> expression)
    {
        RuleFor(expression)
            .NotNull()
            .WithMessage("Id обязателен");
    }

    protected void ValidateScheduleName(Expression<Func<T, string>> expression)
    {
        RuleFor(expression)
            .NotEmpty()
            .WithMessage("Название не должно быть пустым!");

        RuleFor(expression)
            .MinimumLength(ScheduleConstants.NameMinLength)
            .WithMessage($"Минимальное кол-во символов: {ScheduleConstants.NameMinLength}");

        RuleFor(expression)
            .MaximumLength(ScheduleConstants.NameMaxLength)
            .WithMessage($"Максимальное кол-во символов: {ScheduleConstants.NameMaxLength}");
    }

    protected void ValidateStartDate(Expression<Func<T, DateOnly>> expression)
    {
        RuleFor(expression)
            .GreaterThanOrEqualTo(ScheduleConstants.MinStartDate)
            .WithMessage($"Дата начала не может быть раньше {ScheduleConstants.MinStartDate:dd.MM.yyyy}");
    }

    protected void ValidateEndDate(Expression<Func<T, DateOnly>> expression)
    {
        RuleFor(expression)
            .LessThanOrEqualTo(ScheduleConstants.MaxEndDate)
            .WithMessage($"Дата окончания не может быть позже {ScheduleConstants.MaxEndDate:dd.MM.yyyy}");
    }

    protected void ValidateDateRange(
        Expression<Func<T, DateOnly>> startDateExpr,
        Expression<Func<T, DateOnly>> endDateExpr)
    {
        RuleFor(x => endDateExpr.Compile().Invoke(x))
            .GreaterThanOrEqualTo(x => startDateExpr.Compile().Invoke(x))
            .WithMessage("Дата окончания не может быть раньше даты начала");
    }

    protected void ValidateGroupId(Expression<Func<T, int?>> expression)
    {
        RuleFor(expression)
            .NotNull()
            .WithMessage("Группа обязательна для расписания");
    }
}
