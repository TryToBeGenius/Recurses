Console.WriteLine("вВЕДИТЕ НАТУРАЛЬНОЕ ЧИСЛО:");
int num = Convert.ToInt32(Console.ReadLine());


int SummOfDigit(int num) //123 , 12 , 1 , 0
{
    if(num == 0) return 0;
    return num % 10 + SummOfDigit(num/10); //Рекурсивный вызов - 123 => 12 => 1
    // (1 % 10 = 1) + (12 % 10 = 2) + (123 % 10 = 3) = 6 + 0(из ретерна)
}

Console.Write(SummOfDigit(num));