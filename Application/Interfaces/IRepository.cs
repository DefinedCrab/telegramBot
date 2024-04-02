namespace Application.Interfaces;

public interface IRepository<TEntity> {
    public TEntity GetById(Guid id);
    public TEntity Add(TEntity entity);
    public TEntity Update(TEntity entity);
    
    public TEntity Delete(Guid id);
}