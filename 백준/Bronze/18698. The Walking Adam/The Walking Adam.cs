int t = int.Parse(Console.ReadLine()!);

int cnt = 0;
for (int i = 0; i < t; i++)
{
    string n = Console.ReadLine()!;

    for (int j = 0; j < n.Length; j++)
    {
        if (n[j] == 'U') cnt++;
        else break;
    }
    Console.WriteLine(cnt);
    cnt = 0;
}