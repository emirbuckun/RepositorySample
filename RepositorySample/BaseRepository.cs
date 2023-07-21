namespace RepositorySample
{
  internal abstract class BaseRepository<T> where T : BaseEntity
  {
    public abstract void Add(T entity);
    public abstract void Update(T entity);
  }
}