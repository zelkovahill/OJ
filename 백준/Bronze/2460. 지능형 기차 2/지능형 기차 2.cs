int max = 0, sum = 0;

for(int i = 1; i<=10;i++)
{
    string[] A = Console.ReadLine().Split();

    int a = int.Parse(A[0]);
    int b = int.Parse(A[1]);

    sum -= a;
    sum += b;

    if(sum>max)
    {
        max = sum;
    }

}

Console.WriteLine(max);