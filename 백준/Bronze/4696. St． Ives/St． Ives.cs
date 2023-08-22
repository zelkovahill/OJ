while(true)
{
    var a = double.Parse(Console.ReadLine()!);
    if (a == 0) break;

    var b = 1 + a + a * a + a * a * a + a * a * a * a;

    Console.WriteLine(b.ToString("F2"));
}