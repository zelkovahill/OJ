// Math.Min 사용방법
// 두 개의 값 중 작은 값을 반환 출력

var Input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();



Console.WriteLine(Math.Min(Input[0] / 2, Input[1]));



