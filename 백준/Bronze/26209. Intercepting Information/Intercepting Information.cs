// 변수 이름를 잘 만들자 

bool isFail = false;
var input = Console.ReadLine()!.Split(' ');
for(int i=0;i<8;i++)
{
    var bit = int.Parse(input![i]);

    if (bit == 9) isFail = true;
}

if (isFail) Console.WriteLine("F");
else Console.WriteLine("S");