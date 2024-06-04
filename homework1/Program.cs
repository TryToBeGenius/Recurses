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

bool ItIsDigits(string input)
{
    if (input == null) return false;
    if (int.TryParse(input, out int number))
    {
        return true;
    }
    Console.Write($"Неверный ввод, '{input}' STOP.");
    return false;
    
}

Console.Write("Введите численное значение M:");
string str1 = Console.ReadLine();
Console.Write("Введите численное значение N:");
string str2 = Console.ReadLine();

bool output1 = ItIsDigits(str1);
bool output2 = ItIsDigits(str2);



if (output1 == true && output2 == true)
{
    int number1 = Convert.ToInt32(str1);
    int number2 = Convert.ToInt32(str2);    
    if (number1 > number2)
    {
        PrintOutNaturaleNumbersRevers(number2, number1);
    }
    else if (number2 > number1)
    {
        PrintOutNaturaleNumbers(number2, number1);
    }
}
else
{
   Console.Write(" Введите целочисленное значение!"); 
}
