namespace Domain.Entities {
    /// <summary>
    /// Базовый класс для всех сущностей 
    /// </summary>
    public abstract class BaseEntity {
        /// <summary>
        /// Идентификатор сущности 
        /// </summary>
        protected Guid Id { get; set; }

        /// <summary>
        /// Entity creation date
        ///</summary>
        protected DateTime CreationDate { get; set; }

        public override bool Equals(object? obj) {
            if (obj == null) {
                return false;
            }
            
            if (obj is not BaseEntity entity) {
                return false;
            }
        
            return Id == entity.Id;
        }

        
        public override int GetHashCode() {
            //TODO: Зачем переопределять GetHashCode
            return base.GetHashCode();
        }
    }
}