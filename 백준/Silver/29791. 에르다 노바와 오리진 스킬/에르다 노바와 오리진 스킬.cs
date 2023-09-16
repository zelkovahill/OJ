
static int CountKill(int count,int time)
{
    var I = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    Array.Sort(I);
    int resistBefore = I[0];
    int resist = 1;

    for(int i= 1; i<count; i++)
    {
        if (I[i] - resistBefore >=time)
        {
            resist++;
            resistBefore = I[i];
        }
    }

    return resist;
}

string[] input = Console.ReadLine()!.Split(' ');
int n = int.Parse(input[0]);
int m = int.Parse(input[1]);

int E = CountKill(n, 100);
int O = CountKill(m, 360);

Console.WriteLine($"{E} {O}");