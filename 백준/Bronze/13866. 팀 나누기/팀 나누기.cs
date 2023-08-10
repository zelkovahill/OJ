string[] A = Console.ReadLine().Split();

int a = int.Parse(A[0]);
int b = int.Parse(A[1]);
int c = int.Parse(A[2]);
int d = int.Parse(A[3]);

Console.WriteLine(Math.Abs((a + d) - (b + c)));
//틀린 이유 A D가 속한 값보다 B C가 속한 값이 클 수도 있으므로 절댓값을 출력해야 함