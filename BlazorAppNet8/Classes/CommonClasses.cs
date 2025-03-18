namespace BlazorAppNet8.Classes
{
	public static class CommonClasses
	{
		public static string getFullName(INameProvider provider)
		{
			return provider.GetFullName();
		}

		public static string getShortName(INameProvider provider)
		{
			return provider.GetShortName();
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
