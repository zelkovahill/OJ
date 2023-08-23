//데이터 손실로 인한 오

var Input = Console.ReadLine()!.Split(' ').Select(double.Parse).ToArray();

var x = (int)(Input[0] * Input[1] / Input[2]);
var y = (int)(Input[0] / Input[1] * Input[2]);

Console.WriteLine(Math.Max(x,y));

