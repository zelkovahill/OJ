int t = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

var f = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int sum = 0;

for (int i = 0; i < f.Length; i++)
{
    sum += f[i];
}

if (sum - t >= 0) Console.WriteLine("Padaeng_i Happy");
else              Console.WriteLine("Padaeng_i Cry");
         
         