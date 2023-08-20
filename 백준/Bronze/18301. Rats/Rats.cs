string[] A = Console.ReadLine().Split();

int a = int.Parse(A[0]);
int b = int.Parse(A[1]);
int c = int.Parse(A[2]);

int sum = (a + 1) * (b + 1)/(c+1)-1;

Console.WriteLine(sum);