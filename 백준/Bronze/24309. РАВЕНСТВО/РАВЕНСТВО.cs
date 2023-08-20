using System.Numerics;

BigInteger a = BigInteger.Parse(Console.ReadLine());
BigInteger b = BigInteger.Parse(Console.ReadLine());
BigInteger c = BigInteger.Parse(Console.ReadLine());

BigInteger x = (b - c) / a;

Console.WriteLine(x);