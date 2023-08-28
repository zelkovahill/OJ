var N = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

var ans = (N[1] / N[3]) * (N[2] / N[3]);

Console.WriteLine(N[0]<ans ? N[0]:ans);

