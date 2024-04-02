using System.Text.Json;

namespace Domain.ValueObject;

public abstract class BaseValueObject {
     
    // Разобраться с сравнением BaseValueObject V
    public override bool Equals(object? obj) {
        //done? Реализовать DeepCompare (DeepClone)
        if (ReferenceEquals(this, obj)) {
            return true;
        }
    
        if (obj == null) {
            return false;
        }

        string baseObj = JsonSerializer.Serialize(this);
        string anotherObj = JsonSerializer.Serialize(obj);
        //json serializer
        // if (GetType() != obj.GetType()) {
        //     return false;
        // }
        //
        // if (obj.GetType().IsPrimitive && GetType().IsPrimitive) {
        //     return Equals(obj);
        // }
        //
        // var result = true;
        // foreach (var property in obj.GetType().GetProperties()) {
        //     var objValue = property.GetValue(this);
        //     var anotherValue = property.GetValue(obj);
        //     if (objValue == null
        //         || anotherValue == null
        //         || Equals(objValue, anotherValue)) {
        //         result = false;
        //     }
        // }
    
        return baseObj.Equals(anotherObj);
    }


    public override int GetHashCode() {
        int result = 0;
        foreach (var prop in this.GetType().GetProperties()) {
            result += prop.GetHashCode();
        }

        return result * 5;
    }
}