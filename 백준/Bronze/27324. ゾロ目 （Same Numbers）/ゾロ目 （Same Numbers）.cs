var N = int.Parse(Console.ReadLine()!);

var A = N / 10;
var B = N % 10;

if(A==B)
{
    Console.WriteLine("1");
}

else
{
    Console.WriteLine("0");
}