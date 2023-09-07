var T = uint.Parse(Console.ReadLine()!);

while(T>0)
{

    var N =Console.ReadLine()!.Split(' ').Select(uint.Parse).ToArray();
    var A = N[0] * 350.34;
    var B = N[1] * 230.90;
    var C = N[2] * 190.55;
    var D = N[3] * 125.30;
    var E = N[4] * 180.90;
    var sum =A+B+C+D+E;

    Console.WriteLine($"${sum.ToString("F2")}");


    T--;
}