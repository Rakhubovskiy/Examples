Console.Write("Enter username: ");
string username = Console.ReadLine()!;

if (username.ToLower() == "anna")
{
    Console.WriteLine("WOW it's ANNA!");
}
else
{
    Console.Write("Hello ");
    Console.WriteLine(username);
}