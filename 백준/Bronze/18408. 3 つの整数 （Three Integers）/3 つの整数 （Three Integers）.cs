var N = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();


if (N[0] + N[1] + N[2] > 4) Console.WriteLine("2");
else Console.WriteLine("1");