int ObrSchet (int b)
{
    if (b == 0) return 1;
    Console.Write("{0,4}", b);
    return ObrSchet(b - 1);
}

Console.WriteLine("Введите натуральное число больше 1:");
int a = Convert.ToInt32(Console.ReadLine());
if(a<1) Console.WriteLine("Число не больше 1");
else ObrSchet(a);
