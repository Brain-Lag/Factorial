using System;
using System.Diagnostics;
using System.Numerics;

Stopwatch stopwatch = new Stopwatch();
while (true)
{
    Console.WriteLine("Введите число ");
    stopwatch.Start();
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine(FactorialByRec(n));
    stopwatch.Stop();
    Console.WriteLine($"----------Прошло милисекунд: {stopwatch.ElapsedMilliseconds}");
}

static BigInteger Factorial(int x)
{
    BigInteger fact = BigInteger.One;
    for (int i = 1; i <= x; i++)
    {
        fact *= i;
    }
    return fact;
}

static BigInteger FactorialByRec(int x)
{
    BigInteger fact = BigInteger.One;
    if (x == 0) return 1;
    return x * FactorialByRec(x - 1);
}