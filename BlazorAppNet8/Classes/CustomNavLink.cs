using MudBlazor;

namespace BlazorAppNet8.Classes
{
	public class CustomNavLink
	{
		public string NavText { get; set; } = "Home";
		public string NavHref { get; set; } = "/";
		public string NavIconName { get; set; } = @Icons.Material.Filled.Home;
		public Color IconColor { get; set; } = Color.Primary;
		public CustomNavLink? Children { get; set; } = null;
	}
}
