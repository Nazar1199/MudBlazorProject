namespace BlazorAppNet8.Interfaces
{
    public interface INodeCustomData<T> where T: IParentIdNode
    {
        public T Data { get; set; }
    }
}
