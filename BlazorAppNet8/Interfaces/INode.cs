namespace BlazorAppNet8.Components.MyNodes.Interfaces
{
	public interface INode<T> where T : IHierarchyItem
	{
		T Item { get; set; }
		bool IsExpanded { get; set; }
		Action? OnToggleChildren { get; set; }
	}
}
