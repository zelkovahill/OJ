// 가독성 좋게 하는 연습하기

int n = int.Parse(Console.ReadLine());

for(int i = 0; i<n; i++)
{
    var m = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

    int x1 = m[0],
           y1 = m[1],
           r1 = m[2],
           x2 = m[3],
           y2 = m[4],
           r2 = m[5];

    double distance =Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));

    // 두 원이 일치 하면 -1
    if (x1 == x2 && y1 == y2 && r1 == r2)
    { Console.WriteLine("-1"); }

    // 한 점에서 만나면 1
    else if (distance == (double)Math.Abs (r1 - r2) || distance == (double)r1 + r2)
    { Console.WriteLine("1"); }


    // 두점에서 만나면 2
    else if (distance> (Double)(Math.Abs(r1 - r2))   && distance < (Double)r1 + r2) 
        { Console.WriteLine("2"); }


    // 만나지 않으면 0
    else
        Console.WriteLine("0");

}