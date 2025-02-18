namespace BlazorAppNet8
{
	public class User
	{
		public int Id { get; set; }
		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public string? Patronymic { get; set; } = null;
		public string Login { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public string? Password { get; set; } = null;
		public string Phone { get; set; } = string.Empty;
		public string? AvatarURL { get; set; } = null;

		public User(int id)
		{
			Id = id;
		}
	}
}
