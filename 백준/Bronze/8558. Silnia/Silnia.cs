//1. n<=1 n!=1
//2. n>1 n! 1부터 n까지의 곱과 같아 n!

uint n = uint.Parse(Console.ReadLine()!);
uint sum = 1;

for(uint i=1;i<=n;i++)
{
    sum *= i;
}

Console.WriteLine(sum%10);


