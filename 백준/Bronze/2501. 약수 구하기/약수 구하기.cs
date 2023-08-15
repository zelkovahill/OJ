string[] Array = Console.ReadLine().Split();

int N = int.Parse(Array[0]);
int K = int.Parse(Array[1]);

for(int i=1;i<=N;i++)
{
    if (N % i == 0)
{
        K--;
}
    if(K==0)
    {
        Console.WriteLine(i);
        return;
    }

}

Console.WriteLine("0");