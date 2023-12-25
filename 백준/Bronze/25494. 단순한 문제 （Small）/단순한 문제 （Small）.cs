int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    int a = int.Parse(input[0]),
        b = int.Parse(input[1]),
        c = int.Parse(input[2]);
    
    Console.WriteLine(Math.Min(Math.Min(a,b),c));
}