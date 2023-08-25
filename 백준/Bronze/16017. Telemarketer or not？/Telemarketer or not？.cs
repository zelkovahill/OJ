// 네자리 중 첫 번째 자리가 8또는 9
// 마지막 자리 또한 8 또는 9
// 두 번째 자리와 세 번째 자리는 같음

var input = new int[4];

for(int i=0;i<4;i++)
{
    input[i] = int.Parse(Console.ReadLine()!);
}

if ((input[0] == 8 || input[0] == 9) && (input[3] == 8 || input[3] == 9) && (input[1] == input[2]))
    Console.WriteLine("ignore");

else Console.WriteLine("answer");




