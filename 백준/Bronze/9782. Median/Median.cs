//리스트 사용법 

int Count = 1;
while (true)
{
    var input = Console.ReadLine()?.Split(' ');
    var n = int.Parse(input![0]);
    if (n == 0) break;

    List<int> f = new List<int>(n);
    for (int i = 0; i < n; i++)
        f.Add(int.Parse(input![i + 1]));

    double mid = 0.0;
    if (n % 2 == 0) mid = (f[(n / 2) - 1] + f[n / 2]) / 2.0;
    else mid = f[(n - 1) / 2];

    Console.WriteLine($"Case {Count}: {mid:F1}");

    Count++;
}