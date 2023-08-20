int N = int.Parse(Console.ReadLine());

string A = Console.ReadLine();

int cnt = 0;
for(int i=0;i<A.Length;i++)
{
    if (A[i]=='a'||
        A[i] == 'e'||
        A[i] == 'i'||
        A[i] == 'o'||
        A[i] == 'u')
    {
        cnt++;
    }
}

Console.WriteLine(cnt);