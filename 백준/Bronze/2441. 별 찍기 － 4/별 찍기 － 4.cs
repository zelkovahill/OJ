int N = int.Parse(Console.ReadLine());

for(int i = 0; i<N;i++)
{
for(int j=1;j<=i;j++)
    {
        Console.Write(" ");
    }
for(int j=1;j<=N-i;j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
