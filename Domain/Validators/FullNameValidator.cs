using Domain.Primitives;
using Domain.ValueObject;
using FluentValidation;

namespace Domain.Validators;

public class FullNameValidator : AbstractValidator<FullName> {
    public FullNameValidator() {
        RuleFor(f => f.FirstName)
            .NotNull()
            .WithMessage(f => ValidationMessages.NullOrEmpty(nameof(FullName)))
            .NotEmpty()
            .WithMessage(f => ValidationMessages.NullOrEmpty(nameof(FullName)));
        //TODO: validate all other fields

    }
}