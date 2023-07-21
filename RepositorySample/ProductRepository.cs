namespace RepositorySample
{
  internal class ProductRepository
  {
    public void Add(ProductEntity productEntity)
    {
      if (productEntity is null)
      {
        throw new ArgumentNullException(nameof(productEntity));
      }
    }
    public void Update(ProductEntity productEntity)
    {
      if (productEntity is null)
      {
        throw new ArgumentNullException(nameof(productEntity));
      }
    }
  }
}