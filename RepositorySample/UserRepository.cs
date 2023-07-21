namespace RepositorySample
{
  internal class UserRepository
  {
    public void Add(UserEntity userEntity)
    {
      if (userEntity is null)
      {
        throw new ArgumentNullException(nameof(userEntity));
      }
    }
    public void Update(UserEntity userEntity)
    {
      if (userEntity is null)
      {
        throw new ArgumentNullException(nameof(userEntity));
      }
    }
  }
}