using System.Text; // 새로 배운 것 1
// 문자열과 텍스트 데이터에 대한 다양한 처리 기능을 제공

var Input = Console.ReadLine()!;

var gae = new int[26];

for(int i=0;i<Input.Length;i++)
{
    gae[Input[i] - 'a']++;
}

StringBuilder stringBuilder = new StringBuilder(); // 새로 배운 것 2
// 문자열을 효율적으로 변경하고 조작하기 위한 클래스로 문자열 연결 시 발생하는 성능 문제를 최소화

foreach (int a in gae)
{
    stringBuilder.Append(a + " ");
}
Console.WriteLine(stringBuilder);
