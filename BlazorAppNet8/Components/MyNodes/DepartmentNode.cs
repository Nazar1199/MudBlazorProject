using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;
using BlazorAppNet8.Components.MyNodes.Interfaces;
using BlazorAppNet8.Classes;

namespace BlazorAppNet8.Components.MyNodes;
public class DepartmentNode : NodeModel, INode<Department>
{
	public Department Item { get; set; }
	public bool IsExpanded { get; set; }
	public Action? OnToggleChildren { get; set; }

	public DepartmentNode(Department item, Point? position = null)
		: base(position)
	{
		Item = item;
	}
}
