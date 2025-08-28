using FluentValidation;
using Scheduler.Application.Validation.Constants;
using System.Linq.Expressions;

namespace Scheduler.Application.Validation.Validators.Base;

public abstract class BaseLessonValidator<T> : AbstractValidator<T>
{
    protected void ValidateId(Expression<Func<T, int>> expression)
    {
        RuleFor(expression)
            .NotNull()
            .WithMessage("Id обязателен");
    }

    protected void ValidateLessonName(Expression<Func<T, string>> expression)
    {
        RuleFor(expression)
            .NotEmpty()
            .WithMessage("Не должно быть пустым!");

        RuleFor(expression)
            .MinimumLength(LessonConstants.NameMinLength)
            .WithMessage($"Минимальное кол-во символов в имени: {LessonConstants.NameMinLength}");

        RuleFor(expression)
            .MaximumLength(LessonConstants.NameMaxLength)
            .WithMessage($"Максимальное кол-во символов в имени: {LessonConstants.NameMaxLength}");
    }

    protected void ValidateAudienceNumber(Expression<Func<T, string>> expression)
    {
        RuleFor(expression)
            .NotEmpty()
            .WithMessage("Не должно быть пустым!");

        RuleFor(expression)
            .MinimumLength(LessonConstants.AudienceNumberMinLength)
            .WithMessage($"Минимальное кол-во символов в названии: {LessonConstants.AudienceNumberMinLength}");

        RuleFor(expression)
            .MaximumLength(LessonConstants.AudienceNumberMaxLength)
            .WithMessage($"Максимальное кол-во символов в названии: {LessonConstants.AudienceNumberMaxLength}");
    }

    protected void ValidateLessonTime(Expression<Func<T, TimeOnly>> expression)
    {
        RuleFor(expression)
            .InclusiveBetween(LessonConstants.EarliestStartTime, LessonConstants.LatestEndTime)
            .WithMessage("Некорректное время!");
    }

    protected void ValidateLessonTimeRange(
        Expression<Func<T, TimeOnly>> startExpr,
        Expression<Func<T, TimeOnly>> endExpr)
    {
        RuleFor(x => endExpr.Compile().Invoke(x))
            .GreaterThan(x => startExpr.Compile().Invoke(x))
            .WithMessage("Время окончания должно быть позже времени начала");
    }

    protected void ValidateSchoolDayId(Expression<Func<T, int>> expression)
    {
        RuleFor(expression)
            .NotNull()
            .WithMessage("Id дня обязателен");
    }
}