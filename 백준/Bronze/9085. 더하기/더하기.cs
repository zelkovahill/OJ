var T = int.Parse(Console.ReadLine()!);

while(T>0)
{
    var TT = int.Parse(Console.ReadLine()!);
    var tt = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    int sum = 0;

    for(int i=0;i<TT;i++)
    {
        sum += tt[i];
    }

    Console.WriteLine(sum);
    T--;
}