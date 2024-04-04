using Domain.Primitives;
using Domain.ValueObject;

namespace Application.DTOs;

public class PersonGetByIdResponse {
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
    
}