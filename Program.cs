using System;
using System.Diagnostics;
using System.Numerics;

Stopwatch stopwatch = new Stopwatch();
while (true)
{
    Console.WriteLine("Введите число ");
    
    int n = int.Parse(Console.ReadLine());

    stopwatch.Restart();
    var res1 = Factorial(n);
    stopwatch.Stop();
    Console.WriteLine(res1);
    Console.WriteLine($"----------Прошло: {stopwatch.Elapsed}");

    stopwatch.Restart();
    var res2 = FactorialByRec(n);
    stopwatch.Stop();
    Console.WriteLine(res2);
    Console.WriteLine($"----------Прошло: {stopwatch.Elapsed}");
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