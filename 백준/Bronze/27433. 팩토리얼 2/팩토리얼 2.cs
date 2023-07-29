long N = int.Parse(Console.ReadLine());

long sum=1;

for(int i=1;i<=N;i++)
{
     sum *= i;
}

Console.WriteLine(sum);
