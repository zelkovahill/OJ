var N = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

if (N[0] == 0 && N[1] == 0) Console.WriteLine("Not a moose");
else if (N[0] != N[1]) Console.WriteLine($"Odd {Math.Max(N[0], N[1]) * 2}");
else if (N[0] == N[1]) Console.WriteLine($"Even {N[1] * 2}");