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
    
        if (GetType() != obj.GetType()) {
            return false;
        }
    
        if (obj.GetType().IsPrimitive && GetType().IsPrimitive) {
            return Equals(obj);
        }
    
        var result = true;
        foreach (var property in obj.GetType().GetProperties()) {
            var objValue = property.GetValue(this);
            var anotherValue = property.GetValue(obj);
            if (objValue == null
                || anotherValue == null
                || Equals(objValue, anotherValue)) {
                result = false;
            }
        }
    
        return result;
    }


    public override int GetHashCode() {
        return base.GetHashCode();
    }
}