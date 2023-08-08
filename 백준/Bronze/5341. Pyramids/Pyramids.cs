while(true)
{
    var n = int.Parse(Console.ReadLine()!);

    if (n == 0) break;

    var m = n * (n + 1) / 2;
    Console.WriteLine(m);
}