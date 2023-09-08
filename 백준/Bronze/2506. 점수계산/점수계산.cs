var N = int.Parse(Console.ReadLine()!);

var N2 = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

int win = 0;

int cnt = 0;

for(int i=0;i<N;i++)
{
    if (N2[i]==1)
    {
        cnt++;
        win += cnt;
        
    }

    else
    {
        
        cnt = 0;
    }

    
}

Console.WriteLine(win);

