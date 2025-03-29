namespace BlazorAppNet8.Interfaces
{
    public interface IExpandableNode
    {
        public Action? OnToggleExpand { get; set; }
        public bool IsExpanded { get; set; }
    }
}
