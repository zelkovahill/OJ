string I = Console.ReadLine();
int cnt = 0;

for (int i = 0; i < I.Length - 3; i++)
{
    if (I[i] == 'k' && I[i + 1] == 'i' && I[i + 2] == 'c' && I[i + 3] == 'k')
    {
        cnt++;
    }
}
Console.WriteLine(cnt);