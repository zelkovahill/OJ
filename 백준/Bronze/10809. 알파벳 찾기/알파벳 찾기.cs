// 정석 방법

string s = Console.ReadLine().ToLower();
//소 문자 만들어 주+

//아스키 코드를 이.
for(int i =97;i<123;i++)
{
    if (s.Contains(Convert.ToChar(i)))
    {
        Console.Write(s.IndexOf(Convert.ToChar(i)));
        Console.Write(" "); // 띄어쓰기
    }

    else Console.Write("-1 ");
}