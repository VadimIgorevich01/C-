Console.WriteLine("What is your name?");
string username = Console.ReadLine();

if (username.ToLower() == "vadim")
{
    Console.WriteLine("Vadim!!! Nice to see you again");
}
else 
{
    Console.WriteLine("Hello, " + username);
}