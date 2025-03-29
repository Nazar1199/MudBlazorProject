using Blazor.Diagrams.Core.Models;
using Blazor.Diagrams.Core.Geometry;

namespace BlazorAppNet8.Interfaces
{
    public class IParentIdNode(Point? position = null) : NodeModel(position)
    {
        //Скрывает NodeModel.Id
        public int Id { get; set; }
        public int? ParentId { get; set; }
    }
}
