using FluentValidation;
using Scheduler.Core.Enums;
using System.Linq.Expressions;

namespace Scheduler.Application.Validation.Validators.Base;

public abstract class BaseSchoolDayValidator<T> : AbstractValidator<T>
{
    protected void ValidateId(Expression<Func<T, int>> expression)
    {
        RuleFor(expression)
            .NotNull()
            .WithMessage("Id обязателен");
    }

    protected void ValidateWeekParity(Expression<Func<T, WeekParity>> expression)
    {
        RuleFor(expression)
            .NotEmpty()
            .WithMessage("Некорректный тип черты");

        RuleFor(expression)
            .NotEqual(WeekParity.Unspecified)
            .WithMessage("Некорретный тип черты");
    }

    protected void ValidateScheduleId(Expression<Func<T, int>> expression)
    {
        RuleFor(expression)
            .NotNull()
            .WithMessage("Id расписания обязателен");
    }
}
