namespace RepositorySample
{
  internal class BaseEntity
  {
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CreatedById { get; set; }
    public DateTime ModifyDate { get; set; }
    public int ModifiedById { get; set; }
  }
}