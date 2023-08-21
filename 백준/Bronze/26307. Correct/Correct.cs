

var A = Console.ReadLine()!.Split();

int H = int.Parse(A[0]);
int M = int.Parse(A[1]);


var Start = 9 * 60;
var End = H * 60 + M;

var sum = End - Start;

Console.WriteLine(sum);


