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

if (userChoice == "A" || userChoice == "a") 
{
    Console.WriteLine(Addition(num1, num2));
}
else if (userChoice == "S" || userChoice == "s") 
{
    Console.WriteLine(Substraction(num1, num2));
}
else if (userChoice == "M" || userChoice == "m") 
{
    Console.WriteLine(Multiplication(num1, num2));
}
else
{
    Console.WriteLine("Invalid option");
}

Console.WriteLine("Press any key to close");
Console.ReadKey();

string Addition(int num1, int num2)
{
    int result = num1 + num2;
    return $"{num1} + {num2} = {result}";
}

string Substraction(int num1, int num2)
{
    int result = num1 - num2;
    return $"{num1} - {num2} = {result}";
}

string Multiplication(int num1, int num2)
{
    int result = num1 * num2;
    return $"{num1} * {num2} = {result}";
}