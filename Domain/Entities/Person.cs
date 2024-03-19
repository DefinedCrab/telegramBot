using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Domain.Primitives;
using Domain.ValueObject;

namespace Domain.Entities;

public class Person : BaseEntity {
    public FullName FullName { get; private set; }
    //less than 120
    public DateTime Birthday { get; private set; }
    // validate using RegEx as international format
    public string PhoneNumber { get; private set; }
    //@{20 symbols}
    public string Telegram { get; private set; }
    //!null
    public Gender Gender { get; private set; }

    public int Age => DateTime.Now.Year - Birthday.Year;

    public Person(FullName fullName, DateTime birthday, Gender gender, string phoneNumber, string telegram) {
        PhoneNumber = phoneNumber;
        Telegram = telegram;
        this.FullName = ValidateFullName(fullName);
        // todo: *FluentValidator lib
    }

    //TODO: Валидация остальных полей
    private FullName ValidateFullName(FullName fullName) {
        if (string.IsNullOrEmpty(fullName.FirstName)
            || string.IsNullOrEmpty(fullName.LastName)) {
            throw new ValidationException(ValidationMessages.NullOrEmpty);
        }
        //todo: validate by language (ru/en only) and length <=20
        return fullName;
    }
}