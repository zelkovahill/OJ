var input = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

var sum = (input[0] * input[1]) / 2;

Console.WriteLine(sum);