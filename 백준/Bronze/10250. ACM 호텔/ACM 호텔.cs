int T = int.Parse(Console.ReadLine()!);
int x, y;

for(int i=0; i<T; i++)
{
    var N = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    // 호텔의 층 수 / 각 층의 방 수 / 몇 번째 손님
    x = N[2] / N[0] + 1;
    y = N[2] % N[0];

    if(y==0)
    {
        y = N[0];
        x -= 1;
    }
    Console.WriteLine($"{y}{x:D2}");
}