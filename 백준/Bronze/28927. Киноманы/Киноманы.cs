// 새롭게 배운 방식

var Max = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
var Mel = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

int max = 3 * Max[0] + 20 * Max[1] + 120 * Max[2];
int mel = 3 * Mel[0] + 20 * Mel[1] + 120 * Mel[2];

if (max > mel) Console.WriteLine("Max");
else if (max < mel) Console.WriteLine("Mel");
else Console.WriteLine("Draw");