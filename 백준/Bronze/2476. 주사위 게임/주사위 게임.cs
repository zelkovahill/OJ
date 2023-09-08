var T = int.Parse(Console.ReadLine()!);
int Max = 0;



while(T>0)
{
    int a = 0;
    var N = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    Array.Sort(N);

    if (N[0] == N[1] && N[0] == N[2])
    {
        a = 10000 + (N[0] * 1000);
        
    }

    else if (N[0] == N[1] || N[1] == N[2])
    {
        int two = N[0] == N[1] ? N[0] : N[2];

       a = 1000 + (two * 100);

        
    }

    else
    {
        a = N[2] * 100;
        
    }

    if (Max < a) Max = a;

    
    

    T--;

    if(T==0)
    {
        Console.WriteLine(Max);
        break;
    }
}

