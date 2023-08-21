var n = int.Parse(Console.ReadLine()!);

var count5 = n / 5;
var count1 = n % 5;

for(int i=0;i<count5;i++)
{
    Console.Write("V");
}

for(int i=0;i<count1;i++)
{
    Console.Write("I");
}