int[] N = new int[10];

for(int i = 0; i<10; i++)
{
    N[i] = int.Parse(Console.ReadLine()!);  
}

int[] R = new int[42];
int Count = 0;

foreach (int number in N)
{
    int re = number % 42;
    if (R[re] == 0)
    {
        Count++;
        R[re]++;
    }
}

Console.WriteLine(Count);
