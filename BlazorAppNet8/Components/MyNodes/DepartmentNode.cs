using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;
using BlazorAppNet8.Classes;

namespace BlazorAppNet8.Components.MyNodes;
public class DepartmentNode : NodeModel
{
	public DepartmentNode(Point? position = null) : base(position) { }

	public Department Department { get; set; }
	public Action? OnToggleChildren { get; set; }
}
