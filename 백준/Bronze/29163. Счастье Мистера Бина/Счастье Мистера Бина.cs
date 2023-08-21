var N = int.Parse(Console.ReadLine()!);

var n = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

int Count = 0;

for(int i=0;i<N;i++)
{
    if (n[i] % 2 == 0) Count++;
}

if (Count > N / 2) Console.WriteLine("Happy");
else Console.WriteLine("Sad");

