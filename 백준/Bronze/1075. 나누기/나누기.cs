int n = int.Parse(Console.ReadLine()!) / 100 * 100;
int f = int.Parse(Console.ReadLine()!);

for (int i = 0; i < 100; i++)
{
    if (n % f == 0)
    {
        Console.WriteLine("{0:D2}",n%100);
        break;
    }

    n++;
}