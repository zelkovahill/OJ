var N = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
var A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

int min = A[0] * N[1] + A[1] * N[1];


for(int i = 0; i<A.Length-1;i++)
{
    int m = A[i] * N[1] + A[i + 1] * N[1];

    if (min > m) min = m;
}

Console.WriteLine(min);