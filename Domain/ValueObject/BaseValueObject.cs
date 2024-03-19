namespace Domain.ValueObject;

public abstract class BaseValueObject {
     public static bool DeepEquals(object obj, object another) {
         if (ReferenceEquals(obj, another)) {
             return true;
         }
    
         if (obj == null || another == null) {
             return false;
         }
    
         if (obj.GetType() != another.GetType()) {
             return false;
         }
    
         if (obj.GetType().IsPrimitive && another.GetType().IsPrimitive) {
             return obj.Equals(another);
         }
    
         var result = true;
         foreach (var property in obj.GetType().GetProperties()) {
             var objValue = property.GetValue(obj);
             var anotherValue = property.GetValue(another);
             if (objValue == null
                 || anotherValue == null
                 || DeepEquals(objValue, anotherValue)) {
                 result = false;
             }
         }
    
         return result;
     }
    
    // TODO:Разобраться с сравнением BaseValueObject V
    public override bool Equals(object? obj) {
        //TODO:Реализовать DeepCompare (DeepClone)
        return base.Equals(obj);
    }


    public override int GetHashCode() {
        return base.GetHashCode();
    }
}