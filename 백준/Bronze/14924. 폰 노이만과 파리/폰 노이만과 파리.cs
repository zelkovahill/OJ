var input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
// s 기차의 속도 t 파리의 속도 d 처음 두 기차의 사이의 거리

var sum = input[2] / (input[0] * 2);
var sum1 = sum * input[1];

Console.WriteLine(sum1);
