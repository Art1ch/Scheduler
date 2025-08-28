using FluentValidation;
using Scheduler.Application.Validation.Constants;
using System.Linq.Expressions;

namespace Scheduler.Application.Validation.Validators.Base;

public abstract class BaseGroupValidator<T> : AbstractValidator<T>
{
    protected void ValidateId(Expression<Func<T, int>> expression)
    {
        RuleFor(expression)
            .NotNull()
            .WithMessage("Id обязателен");
    }

    protected void ValidateGroupName(Expression<Func<T, string>> expression)
    {
        RuleFor(expression)
            .NotEmpty()
            .WithMessage("Не должно быть пустым!");

        RuleFor(expression)
            .MinimumLength(FacultyConstants.NameMinLength)
            .WithMessage($"Минимальное кол-во символов в имени: {GroupConstants.NameMinLength}");

        RuleFor(expression)
            .MaximumLength(FacultyConstants.NameMinLength)
            .WithMessage($"Максимальное кол-во символов в имени: {GroupConstants.NameMaxLength}");
    }

    protected void ValidateFacultyId(Expression<Func<T, int>> expression)
    {
        RuleFor(expression)
            .NotNull()
            .WithMessage("Id факультета обязателен");
    }
}
