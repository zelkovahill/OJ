int N = int.Parse(Console.ReadLine()!);

int sum = 1;

for (int i = 0; i < N; i++)
{
    sum *= 2;
}
Console.WriteLine(sum);