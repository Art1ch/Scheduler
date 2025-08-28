using FluentValidation;
using Scheduler.Application.Validation.Constants;
using System.Linq.Expressions;

namespace Scheduler.Application.Validation.Validators.Base;

public abstract class BaseFacultyValidator<T> : AbstractValidator<T>
{
    protected void ValidateId(Expression<Func<T, int>> expression)
    {
        RuleFor(expression)
            .NotNull()
            .WithMessage("Id обязателен");
    }

    protected void ValidateFacultyName(Expression<Func<T, string>> expression)
    {

        RuleFor(expression)
            .NotEmpty()
            .WithMessage("Не должно быть пустым!");

        RuleFor(expression)
            .MinimumLength(FacultyConstants.NameMinLength)
            .WithMessage($"Минимальное кол-во символов в имени: {FacultyConstants.NameMinLength}");

        RuleFor(expression)
            .MaximumLength(FacultyConstants.NameMinLength)
            .WithMessage($"Максимальное кол-во символов в имени: {FacultyConstants.NameMaxLength}");
    }
}