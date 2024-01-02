string[] input = Console.ReadLine()!.Split(' ');
int      n     = int.Parse(input[0]),
         m     = int.Parse(input[1]);

int[]   basket     = new int[n+1];

for (int p = 0; p < m; p++)
{
    string[] input2 = Console.ReadLine()!.Split(' ');
    int      i      = int.Parse(input2[0]),
             j      = int.Parse(input2[1]),
             k      = int.Parse(input2[2]);

    for (int q = i; q <= j; q++)
    {
        basket[q] = k;
    }
}

for(int i =1;i<basket.Length;i++)
{
    Console.Write("{0} ",basket[i]);
}