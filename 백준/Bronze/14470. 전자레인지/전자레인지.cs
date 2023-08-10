

int a = int.Parse(Console.ReadLine()); // 현재 고기 온도 
int b = int.Parse(Console.ReadLine()); // 목표 온도 
int c = int.Parse(Console.ReadLine()!); // 얼어 있는 고기 1도 데우는 데 걸리는 시간
int d = int.Parse(Console.ReadLine()!); // 얼어 있는 고기 해동하는데 걸리는 시간 
int e = int.Parse(Console.ReadLine()!); // 얼어 있지 않는 고기 1도 걸리는 데 걸리는 시간

int f = 0; // 걸린 시간 


if(a<0)
{
    Console.WriteLine((Math.Abs(a)) * c + d + b * e);
}

else
{
    Console.WriteLine((b - a) * e);
}

// 이 문제 6번 틀림 