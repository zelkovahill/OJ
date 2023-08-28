using System.Numerics;

BigInteger N = BigInteger.Parse(Console.ReadLine()!);

N = N % 8;

if (N == 1) Console.WriteLine("1");
else if (N == 0 || N == 2) Console.WriteLine("2");
else if (N == 3 || N == 7) Console.WriteLine("3");
else if (N == 4 || N == 6) Console.WriteLine("4");
else if (N == 5) Console.WriteLine("5");


