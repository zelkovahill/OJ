using System.Numerics;

var input = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

if (input[0] % 2 == 0 || input[1] % 2 == 0) Console.WriteLine("0");
else
{
    Array.Sort(input);
    Console.WriteLine(input[0]);
}