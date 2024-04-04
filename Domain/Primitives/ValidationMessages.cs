namespace Domain.Primitives;
// done? make exceptions universal, (StringBuilder, StringFormatter)
public static class ValidationMessages {
    //public static string NullOrEmpty = "Объект не может быть NULL или пустым";
    public static Func<string, string> NullOrEmpty = s => $"Объект {s} или его поле не может быть NULL или пустым";
    public static Func<string, string> InvalidValue = s => $"Недопустимое значение у поля/полей объекта {s}";
}