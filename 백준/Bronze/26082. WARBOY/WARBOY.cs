// var를 자주 쓰자

var i = Console.ReadLine()?.Split();

var a = int.Parse(i![0]);
var b = int.Parse(i![1]);
var c = int.Parse(i![2]);

var d = 3 * (b / a) * c;

Console.WriteLine(d);