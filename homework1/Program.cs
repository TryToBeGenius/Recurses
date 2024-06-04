void PrintOutNaturaleNumbers(int num1, int num2)
{
    if (num1 + 1 == num2) return;
    PrintOutNaturaleNumbers(num1 - 1, num2);
    Console.Write($"{num1} ");
}

void PrintOutNaturaleNumbersRevers(int num1, int num2)
{
    if (num1 - 1 == num2) return;
    PrintOutNaturaleNumbersRevers(num1 + 1, num2);
    Console.Write($"{num1} ");
}

bool ItIsDigits(string input, int index = 0)
{
    if (index == input.Length)
    {
        return true;
    }
    if (char.IsAsciiLetter(input[index]))
    {
        Console.Write($"Неверный ввод:{input[index]}");
    }
    ItIsDigits(input, index + 1);
    return false;
}

Console.WriteLine("Введите численное значение M");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите численное значение N");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    PrintOutNaturaleNumbersRevers(number2, number1);
}
if (number2 > number1)
{
    PrintOutNaturaleNumbers(number2, number1);
}










