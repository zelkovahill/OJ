// 기차에 사람이 가장 많을 때의 사람 수를 계산 하는 프로그램

int max = 0,sum=0;

for(int i=1;i<=4;i++)
{
    string[] A = Console.ReadLine().Split();

    int a = int.Parse(A[0]);
    int b = int.Parse(A[1]);

    sum += b;
    sum -= a;

    if (max < sum) max = sum;

}

Console.WriteLine(max);