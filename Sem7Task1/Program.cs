Console.WriteLine("вВЕДИТЕ НАТУРАЛЬНОЕ ЧИСЛО:");
int number = Convert.ToInt32(Console.ReadLine());

void PrintOutNaturaleNumbers(int num)
{
    if (num == 0) return;
    PrintOutNaturaleNumbers(num-1);
    Console.Write($"{num} ");
}

PrintOutNaturaleNumbers(number);