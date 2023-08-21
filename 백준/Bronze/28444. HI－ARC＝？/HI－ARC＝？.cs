var O = Console.ReadLine()!.Split();

int H = int.Parse(O[0]);
int I = int.Parse(O[1]);
int A = int.Parse(O[2]);
int R = int.Parse(O[3]);
int C = int.Parse(O[4]);

int sum = (H * I) - (A * R * C);

Console.WriteLine(sum);