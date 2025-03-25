using Blazor.Diagrams.Core.Models.Base;
using Blazor.Diagrams.Core.Models;
using Blazor.Diagrams.Core.Geometry;

namespace BlazorAppNet8.Components.MyNodes
{
    public class MyCustomPortModel : PortModel
    {
        public bool In { get; set; }

        public MyCustomPortModel(NodeModel parent, bool @in, PortAlignment alignment = PortAlignment.Top, Point? position = null, Size? size = null) : base(parent, alignment, position, size)
        {
            In = @in;
        }

        public MyCustomPortModel(string id, NodeModel parent, bool @in, PortAlignment alignment = PortAlignment.Top, Point? position = null, Size? size = null) : base(id, parent, alignment, position, size)
        {
            In = @in;
        }

        public override bool CanAttachTo(ILinkable other)
        {
            if (!base.CanAttachTo(other)) // default constraints
                return false;

            if (other is not MyCustomPortModel otherPort)
                return false;

            // Only link Ins with Outs
            return In != otherPort.In;
        }
    }
}
