using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Domain.Primitives;
using Domain.Validators;
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
    public List<CustomField<string>> CustomFields { get; set; } 

    public int Age => DateTime.Now.Year - Birthday.Year;
    //TODO: Implement FluentValidation
    public Person(FullName fullName, DateTime birthday, Gender gender, string phoneNumber, string telegram) {
        PhoneNumber = phoneNumber;
        Telegram = telegram;
        
        

        // todo: *FluentValidator lib
    }

    //TODO: Валидация остальных полей
    private FullName ValidateFullName(FullName fullName) {
        //validate inside of object
        // if (string.IsNullOrEmpty(fullName.FirstName)
        //     || string.IsNullOrEmpty(fullName.LastName)) {
        //     throw new ValidationException(ValidationMessages.NullOrEmpty(nameof(FullName)));
        // }
        // //todo: validate by language (ru/en only) and length <=20
        // if (fullName.FirstName.Length > 20 
        //     || fullName.LastName.Length > 20 
        //     || fullName.MiddleName.Length > 20) {
        //     throw new ValidationException(ValidationMessages.InvalidValue(nameof(FullName)));
        // }
        return fullName;
    }
}