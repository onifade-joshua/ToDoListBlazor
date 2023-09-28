public class ErrorManager
{
	public string? ErrorMessage { get; private set; }

	public void SetErrorMessage(string message)
	{
		ErrorMessage = message;
	}

	public void ClearErrorMessage()
	{
		ErrorMessage = string.Empty;
	}
}