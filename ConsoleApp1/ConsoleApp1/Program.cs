// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input Prime Number: ");
string input = Console.ReadLine();

//check prime numbers
if(Convert.ToInt32(input) % 2 != 0) // even numbers
{
    Console.WriteLine("Prime number");
}
else
{
    Console.WriteLine("Even number");
}



Console.WriteLine("Input Palindrome: ");
string palindromInput = Console.ReadLine();

char[] reverseChar = palindromInput.ToCharArray();
Array.Reverse(reverseChar);
//string reverseInput = Convert.ToString(reverseChar);

string reverseInput = new string(reverseChar);

if (palindromInput == reverseInput)
{
    Console.WriteLine("Palindrome");
}
else
{
    Console.WriteLine("Not Palindrome");
}