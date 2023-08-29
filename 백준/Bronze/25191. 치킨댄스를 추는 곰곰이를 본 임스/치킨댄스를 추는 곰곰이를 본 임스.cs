var N = uint.Parse(Console.ReadLine()!);

var C = Console.ReadLine()!.Split(' ').Select(uint.Parse).ToArray();

var ans = C[0]/2 + C[1];

Console.WriteLine(ans <= N ? ans : N); 