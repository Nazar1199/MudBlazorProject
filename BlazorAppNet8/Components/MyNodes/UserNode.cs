using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace BlazorAppNet8.Components.MyNodes;
public class UserNode : NodeModel
{
    public UserNode(Point? position = null) : base(position) { }

    public User User { get; set; }
}
