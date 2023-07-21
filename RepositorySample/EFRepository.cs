namespace RepositorySample
{
  internal class EFRepository<T> : BaseRepository<T> where T : BaseEntity
  {
    public override void Add(T entity)
    {
      // ...
    }

    public override void Update(T entity)
    {
      // ...
    }
  }
}