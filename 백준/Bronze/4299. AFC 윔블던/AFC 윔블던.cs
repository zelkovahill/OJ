var N = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

// 합 과 차

if (N[0] < N[1]) Console.WriteLine("-1");

else
{
    int x = ((N[0] + N[1]) / 2);
    int y = ((N[0] - N[1]) / 2);

    if (x + y == N[0] && x - y == N[1]) Console.WriteLine(x + " " + y);
    else Console.WriteLine("-1");

}
