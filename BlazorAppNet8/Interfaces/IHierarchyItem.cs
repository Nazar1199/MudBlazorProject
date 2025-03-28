namespace BlazorAppNet8.Components.MyNodes.Interfaces
{	public interface IHierarchyItem
	{
		int Id { get; }
		int? ParentId { get; }
	}
}
