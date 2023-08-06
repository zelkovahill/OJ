
using System.Numerics;

string[] a = Console.ReadLine().Split();
BigInteger A = BigInteger.Parse(a[0]);
BigInteger B = BigInteger.Parse(a[1]);
BigInteger C = A * B;

Console.WriteLine(C);
