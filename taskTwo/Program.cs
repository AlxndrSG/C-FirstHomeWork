Console.Clear();

Console.Write("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
Console.Write("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
int userNumderA = int.Parse (userInput1);
int userNumderB = int.Parse (userInput2);

int max = userNumderA;

if (userNumderB > max) max = userNumderB;

Console.WriteLine($"max = {max}");