using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace BlazorAppNet8.Interfaces
{
    public abstract class AbstractCustomNode<T>(Point? position = null) : NodeModel(position), IExpandableNode where T : IParentIdNode
    {
        public T Data { get; set; }
        public Action? OnToggleExpand { get; set; }
        public bool IsExpanded { get; set; }
    }
}