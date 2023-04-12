Console.Clear();

Console.Write("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
Console.Write("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
int userNumberA = int.Parse(userInput1);
int userNumberB = int.Parse(userInput2);

int max = userNumberA;

if (userNumberB > max)
{
    max = userNumberB;
}

Console.WriteLine($"max = {max}");