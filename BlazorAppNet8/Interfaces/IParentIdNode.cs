namespace BlazorAppNet8.Interfaces
{
    public interface IParentIdNode
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
    }
}
