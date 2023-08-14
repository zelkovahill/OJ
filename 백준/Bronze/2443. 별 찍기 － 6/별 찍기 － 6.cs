int N = int.Parse(Console.ReadLine());

for (int i = N; i > 0; i--)
{
    for(int j = N-i;j>0;j--)
    {
        Console.Write(" ");
    }

    for(int j =2*i-1;j>0;j--)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}