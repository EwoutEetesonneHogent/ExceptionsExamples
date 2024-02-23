Console.WriteLine("Please enter a number");
string userInput = Console.ReadLine();

try
{
	double.Parse(userInput);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}