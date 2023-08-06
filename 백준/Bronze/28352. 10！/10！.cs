long N = long.Parse(Console.ReadLine());

long sum = 1;
long E = 0;

for(long i=1;i<=N;i++)
{
    sum *= i;
    
}
E = 7 * 24 * 60 * 60;

Console.WriteLine(sum/E);