Console.WriteLine("Please enter a number");
string userInput = Console.ReadLine();

try
{
	double.Parse(userInput);
}
catch
{
    Console.WriteLine("Er liep iets fout");
}