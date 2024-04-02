namespace Domain.Entities;

public class CustomField<TValue> : BaseEntity{
    public CustomField() {
        //null empty validation
    }
    public string Name { get; set; }
    public TValue Value { get; set; }
}