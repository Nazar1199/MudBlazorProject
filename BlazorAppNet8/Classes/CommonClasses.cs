namespace BlazorAppNet8.Classes
{
	public static class CommonClasses
	{
		public static string getFullName(User user)
		{
			string fullName = $"{user.LastName} {user.FirstName}";
			if (string.IsNullOrEmpty(user.Patronymic) == false)
			{
				fullName += $" {user.Patronymic}";
			}
			return fullName;
		}

		public static string getShortName(User user)
		{
			string shortName = $"{user.LastName} {user.FirstName[0]}.";
			if (string.IsNullOrEmpty(user.Patronymic) == false)
			{
				shortName += $" {user.Patronymic[0]}.";
			}
			return shortName;
		}

		public static string getFirstChar(string stringValue)
		{
			if (string.IsNullOrEmpty(stringValue) == false)
			{
				return stringValue[0].ToString();
			}
			return string.Empty;
		}
	}
}
