namespace RepositorySample
{
  internal class Program
  {
    private static void Main()
    {
      // Non-generic Usage
      ProductRepository productRepository = new();
      productRepository.Add(new ProductEntity());

      UserRepository userRepository = new();
      userRepository.Add(new UserEntity());

      // Generic Usage
      EFRepository<ProductEntity> efProdRepository = new();
      efProdRepository.Add(new ProductEntity());
      efProdRepository.Update(new ProductEntity());

      EFRepository<UserEntity> efUserRepository = new();
      efUserRepository.Add(new UserEntity());
      efUserRepository.Update(new UserEntity());
    }
  }
}