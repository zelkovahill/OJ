var Max = 0;
int Num = 0;
int I = 0;

for (int i = 1; i <= 5; i++)
{
    var N = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    int sum = N[0] + N[1] + N[2] + N[3];

    if (Max < sum) { Max = sum;I = i; }
        Num++;

}

Console.WriteLine($"{I} {Max}");