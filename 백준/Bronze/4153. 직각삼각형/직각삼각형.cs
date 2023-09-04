while(true)
{
    var N = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    Array.Sort(N);
    if (N[0] == 0 && N[1] == 0 && N[2] == 0) break;

    if (Math.Pow(N[0],2)+Math.Pow(N[1],2)==Math.Pow(N[2],2)) Console.WriteLine("right");
    else Console.WriteLine("wrong");


}
