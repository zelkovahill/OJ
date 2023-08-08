/* 한수는 지금 (x,y)에 있다 직사각형은 각 변이 좌표측에 평행하고
 * 왼쪽 아래 꼭짓점은 (0,0) 오른쪽 위 꼭짓점은 (w,h)에 있다
 * 직사각형의 경계선까지 가는 거리의 최솟갑을 구하는 프로그램을 작성하시오 */


string[] A = Console.ReadLine().Split();

int x = int.Parse(A[0]);
int y = int.Parse(A[1]);
int w = int.Parse(A[2]);
int h = int.Parse(A[3]);


if(w-x>h-y)
{
    if (h - y > x)
    {
        Console.WriteLine(x > y ? y : x);
    }

    else if (h - y > y)
    {
        Console.WriteLine(y > x ? x : y);
    }

    else
        Console.WriteLine(h - y);
}

else
{
    if (w - x > x)
    {
        Console.WriteLine(x > y ? y : x);
    }

    else if (w - x > y)
    {
        Console.WriteLine(y > x ? x : y);
    }

    else
        Console.WriteLine(w - x);
}

