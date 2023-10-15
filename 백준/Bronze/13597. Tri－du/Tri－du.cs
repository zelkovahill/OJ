string[] n = Console.ReadLine().Split(' ');
int a = int.Parse(n[0]),
      b = int.Parse(n[1]);

if (a == b) Console.WriteLine(a);
else Console.WriteLine(Math.Max(a, b));

