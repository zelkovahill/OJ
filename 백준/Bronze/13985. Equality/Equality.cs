string []  n = Console.ReadLine().Split(' ');

int a = int.Parse(n[0]);
char b = char.Parse(n[1]);
int c = int.Parse(n[2]);
char d = char.Parse(n[3]);
int e = int.Parse(n[4]);

if (a + c == e) Console.WriteLine("YES");
else Console.WriteLine("NO");
