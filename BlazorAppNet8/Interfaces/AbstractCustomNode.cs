using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace BlazorAppNet8.Interfaces
{
    public abstract class AbstractCustomNode<T> : NodeModel, IExpandableNode where T : IParentIdNode
    {
	    public AbstractCustomNode(Point? position = null) : base(position) { }
        public T Data { get; set; }
        public Action? OnToggleExpand { get; set; }
        public bool IsExpanded { get; set; }
    }
}