using CustomException;

Console.WriteLine("Please input email");

string userInput = Console.ReadLine();

try
{
	if (!userInput.Contains("@"))
	{
		throw new InvalidEmailException(userInput);
	}
}
catch (InvalidEmailException ex) { Console.WriteLine(ex.Message); }