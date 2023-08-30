var N = int.Parse(Console.ReadLine()!);
var A = int.Parse(Console.ReadLine()!);

for (int i = N; i <= A; i += 60)
{
    Console.WriteLine($"All positions change in year {i}");
} 