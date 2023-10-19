int op1, op2;
var a = int.Parse(Console.ReadLine());
var b = int.Parse(Console.ReadLine());
var c = int.Parse(Console.ReadLine());
var d = int.Parse(Console.ReadLine());
var e = int.Parse(Console.ReadLine());

if (e > 30) op1 = a + (e - 30) * b * 21;
else op1 = a;

if (e > 45) op2 = c + (e - 45) * d * 21;
else op2 = c;

Console.WriteLine($"{op1} {op2}");