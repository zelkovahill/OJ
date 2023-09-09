var input = Console.ReadLine()!.Split(' ').ToArray();
var charInput = Console.ReadLine()!;

List<int> list = new List<int>();
foreach (string str in input)
    list.Add(int.Parse(str));

list.Sort();

Dictionary<string, int> dict = new Dictionary<string, int>();
dict.Add("A", list[0]);
dict.Add("B", list[1]);
dict.Add("C", list[2]);

for (int i = 0; i < charInput.Length - 1; i++)
{
    int num;
    dict.TryGetValue(charInput.Substring(i, 1), out num);
    Console.Write("{0} ", num);
}
int last;
dict.TryGetValue(charInput.Substring(2, 1), out last);
Console.Write(last);

// 코드 리뷰 할 것
// 비주얼 스튜디오가 맛이 갔다