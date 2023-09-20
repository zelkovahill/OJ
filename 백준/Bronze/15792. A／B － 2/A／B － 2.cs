using System.Numerics;

var N = Console.ReadLine()!.Split(' ').Select(Double.Parse).ToArray();
Double sum = N[0] / N[1];

Console.WriteLine(sum);