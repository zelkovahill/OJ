var N = int.Parse(Console.ReadLine()!);

for(int i =0;i<N;i++)
{
    var I = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    int sum = I[0] * I[1]/2;
    Console.WriteLine(sum);
}