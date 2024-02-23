Console.WriteLine("Please enter a file path");

try
{
	Console.WriteLine( File.ReadAllText(Console.ReadLine()));
}
catch (EndOfStreamException)
{
	Console.WriteLine("File was not found, please try again");
}
catch (NullReferenceException ex)
{
	Console.WriteLine(ex.Message);
}

Console.WriteLine("Success!");