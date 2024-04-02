using Domain.Validators;

namespace Domain.ValueObject;
/// <summary>
/// Describes full name. Requires first name and last name, middle name is optional
/// </summary>
public class FullName : BaseValueObject {
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public string? MiddleName { get; set; } = null;

    public FullName(string firstName, string lastName, string middleName) {
        var validateFullName = new FullNameValidator();
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
    }
}