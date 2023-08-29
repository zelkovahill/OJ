var A = uint.Parse(Console.ReadLine()!);
var B = uint.Parse(Console.ReadLine()!);

var re =(A+B)%12;

if (re == 0) re = 12;
Console.WriteLine(re);