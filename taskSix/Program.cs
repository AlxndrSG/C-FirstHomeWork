Console.Clear();

Console.Write("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);

if (userNumber %2 == 0)
{
    Console.WriteLine($"{userNumber} -> Да");
}
else
{
    Console.WriteLine($"{userNumber} -> Нет");
}


