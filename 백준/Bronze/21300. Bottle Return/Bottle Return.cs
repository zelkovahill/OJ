int sum = 0;

string[] A = Console.ReadLine().Split();

int a = int.Parse(A[0]);
int b = int.Parse(A[1]);
int c = int.Parse(A[2]);
int d = int.Parse(A[3]);
int e = int.Parse(A[4]);
int f = int.Parse(A[5]);

sum = (a + b + c + d + e + f) * 5;

Console.WriteLine(sum);