Console.Clear();

Console.Write("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);

int index = 1;

while (index <= userNumber)
{
    if (index % 2 == 0)
    {
        Console.Write(index+",");
    }

    index++;
}

