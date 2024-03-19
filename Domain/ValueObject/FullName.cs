namespace Domain.ValueObject;
/// <summary>
/// Describes full name. Requires first name and last name, middle name is optional
/// </summary>
public class FullName : BaseValueObject {
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? MiddleName { get; set; } = null;

    public FullName(string firstName, string lastName, string middleName) {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
    }
}