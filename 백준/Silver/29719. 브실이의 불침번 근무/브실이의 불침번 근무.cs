using System.Numerics;
using System.Reflection;
// 조합론 문제 (중복 순열 계산)

const long MOD = 1000000007;

string[] input = Console.ReadLine()!.Split(' ');
int n = int.Parse(input[0]);
int m = int.Parse(input[1]);

long result = (PowerMod(m, n, MOD) - PowerMod(m - 1, n, MOD) + MOD) % MOD;
Console.WriteLine(result);

static long PowerMod(int a, int b, long c)
    {
    if (b == 0)
        return 1;
    if (b % 2 == 0)
    {
        long half = PowerMod(a, b / 2, c);
        return (half * half) % c;
    }
    else
    {
        return (a * PowerMod(a, b - 1, c)) % c;
    }
}

//시간초과 때문에 
