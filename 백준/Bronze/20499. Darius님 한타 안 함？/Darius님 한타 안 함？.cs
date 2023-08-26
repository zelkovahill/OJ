var N = Console.ReadLine()!.Split('/').Select(int.Parse).ToArray();

if (N[0] + N[2] < N[1] || N[1] == 0) Console.WriteLine("hasu");
else Console.WriteLine("gosu");