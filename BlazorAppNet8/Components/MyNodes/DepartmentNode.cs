using Blazor.Diagrams.Core.Geometry;
using BlazorAppNet8.Interfaces;
using BlazorAppNet8.Classes;

namespace BlazorAppNet8.Components.MyNodes;
public class DepartmentNode : AbstractCustomNode<Department>
{
	public DepartmentNode(Point? position = null) : base(position) { }
	public Department Department
	{
		get => Data;
		set => Data = value;
	}
	public Action? OnToggleChildren { get; set; }
	public bool IsExpanded { get; set; }
}
