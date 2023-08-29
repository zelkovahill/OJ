var N = int.Parse(Console.ReadLine()!);

var Cnt1 = 0;
var Cnt2 = 0;

var win = 0;

while (N > 0)
{

    var input = Console.ReadLine()!.ToUpper();

    if (input == "D")
    { Cnt1++; }

    else if (input == "P")
    { Cnt2++; }

    if (Math.Abs(Cnt1 - Cnt2)==2) break;

    // 경기 진행 도중 누군가가 2점 앞서게 되면 경기가 종료

    






    N--;
}
Console.WriteLine($"{Cnt1}:{Cnt2}");