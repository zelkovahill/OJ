var input = Console.ReadLine()!;
var N = int.Parse(Console.ReadLine()!);

var count = 0;

while(N>0)
{
    var N2 = Console.ReadLine()!;

    if (input == N2) count++;



    N--;
}

Console.WriteLine(count);
