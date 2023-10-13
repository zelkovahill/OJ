string[] n = Console.ReadLine().Split(' ');
int A = int.Parse(n[0]);
int B = int.Parse(n[1]);

double M = (B - A) / 400d;

double res = 1 / (1 + (Math.Pow(10, M)));

Console.WriteLine(res);

