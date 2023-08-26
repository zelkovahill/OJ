using System.Numerics;

BigInteger result = 0;

for (int i = 0; i < 3; i++)
{
    var N = int.Parse(Console.ReadLine()!);
    for (int j = 0; j < N; j++)
    {
        var N2 = BigInteger.Parse(Console.ReadLine()!);
        result += N2;
    }

    if (result > 0) Console.WriteLine("+");
    else if (result < 0) Console.WriteLine("-");
    else Console.WriteLine("0");

    result = 0; // 각 테스트 케이스가 끝난 후 결과 초기화
}
