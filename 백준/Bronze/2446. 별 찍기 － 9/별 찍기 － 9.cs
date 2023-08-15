int N = int.Parse(Console.ReadLine());

for(int i =1;i<=N;i++)
{
    for(int j=i-1;j>0;j--)
    {
        Console.Write(" ");
    }

    for(int j=2*N-i*2+1;j>0;j--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

for(int i =N-1;i>0;i--)
{
    for(int j=i-1;j>0;j--)
    {
        Console.Write(" ");
    }

    for(int j=2*N-i*2+1;j>0;j--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}