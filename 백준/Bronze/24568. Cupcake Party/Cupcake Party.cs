int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int ans = a * 8 + b * 3 - 28;

if (ans < 0) ans = 0;

Console.WriteLine(ans);