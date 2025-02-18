namespace BlazorAppNet8
{
	public class PrType
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;

		public PrType(int id, string name) {
			Id = id;
			Name = name;
		}
	}
}
