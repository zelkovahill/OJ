var T = int.Parse(Console.ReadLine()!);

while(T>0)
{
    var N = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

    var result = N[0];

    N[1] = N[1] % 4 + 4;

    for(long i = 2; i <= N[1];i++)
    {
        result = (result * N[0]) % 10;
    }

    if (result == 0) result = 10;

    Console.WriteLine(result);

    T--;

}

