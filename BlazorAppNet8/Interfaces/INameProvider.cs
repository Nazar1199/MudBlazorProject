public interface INameProvider
{
	/// <summary>
	/// Возвращает полное имя.
	/// </summary>
	string GetFullName();

	/// <summary>
	/// Возвращает короткое имя.
	/// </summary>
	string GetShortName();
}