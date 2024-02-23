namespace CustomException
{
	internal class InvalidEmailException : ApplicationException
	{
		public InvalidEmailException(string userInput) : base($"Input entered was wrong: {userInput}")
		{
		_userInput = userInput;

		}

		private string _userInput;
	}
}
