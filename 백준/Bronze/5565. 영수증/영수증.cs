var sum = int.Parse(Console.ReadLine()!);

for(int i=0; i<9;i++)
{
    var N =int.Parse(Console.ReadLine()!);
    sum -= N;
}

Console.WriteLine(sum);