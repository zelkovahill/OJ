var N = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= N; i++)
{
    Console.Write(i + " ");
    if (i % 6 == 0) Console.Write("Go! ");
    else if (i == N) Console.Write("Go!");
}