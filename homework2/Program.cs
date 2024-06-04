int Ack(int n,int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return Ack(n - 1, 1);
    return Ack(n - 1, Ack(n , m - 1));
}

Console.WriteLine("Введите численное значение n");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите численное значение m");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write(Ack(n1, m1));
