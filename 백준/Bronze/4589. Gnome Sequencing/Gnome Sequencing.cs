var N = int.Parse(Console.ReadLine()!);

Console.WriteLine("Gnomes:");

for(int i= 0; i<N;i++)
{
    var A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    if ((A[0] > A[1] && A[1] > A[2]) || (A[0] < A[1] && A[1] < A[2]))
    {
        Console.WriteLine("Ordered");
    }

    else Console.WriteLine("Unordered");

}