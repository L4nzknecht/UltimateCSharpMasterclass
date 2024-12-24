// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello!");


Console.WriteLine("Input the first number:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

string userChoice = Console.ReadLine();

if (IsUserChoice(userChoice, "a"))
{
    int result = num1 + num2;
    PrintOperationResult(num1, num2, result, "+");
}
else if (IsUserChoice(userChoice, "s"))
{
    int result = num1 - num2;
    PrintOperationResult(num1, num2, result, "-");
}
else if (IsUserChoice(userChoice, "m"))
{
    int result = num1 * num2;
    PrintOperationResult(num1, num2, result, "*");
}
else
{
    Console.WriteLine("Invalid option");
}

Console.WriteLine("Press any key to close");
Console.ReadKey();

#region Methods
void PrintOperationResult(int num1, int num2, int result, string @operator)
{
    Console.WriteLine($"{num1} {@operator} {num2} = {result}");
}

static bool IsUserChoice(string userChoice, string comparison)
{
    return userChoice.ToUpper() == comparison.ToUpper();
}
#endregion