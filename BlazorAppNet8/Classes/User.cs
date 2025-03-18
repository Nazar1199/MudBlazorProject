namespace BlazorAppNet8
{
	public class User : INameProvider
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
		public string GetFullName()
		{
			string fullName = $"{LastName} {FirstName}";
			if (!string.IsNullOrEmpty(Patronymic))
			{
				fullName += $" {Patronymic}";
			}
			return fullName;
		}
		public string GetShortName()
		{
			if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName))
			{
				throw new ArgumentException("FirstName и LastName не могут быть пустыми.");
			}

			string shortName = $"{LastName} {FirstName[0]}.";
			if (!string.IsNullOrEmpty(Patronymic))
			{
				shortName += $" {Patronymic[0]}.";
			}
			return shortName;
		}
	}
}
