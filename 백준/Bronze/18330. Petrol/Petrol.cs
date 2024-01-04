int n = int.Parse(Console.ReadLine()!);
int k = int.Parse(Console.ReadLine()!);

int q = Math.Min(n, k + 60);

int res = 1500 * q + 3000 * (n - q);

Console.WriteLine(res);