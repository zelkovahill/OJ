var Input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
Array.Sort(Input); // 오름차순 정렬 해보기

if (Input[0] == Input[1] && Input[0] == Input[2]) Console.WriteLine("2");

// else if (Input[0] * Input[0] + Input[1] * Input[1] == Input[2] * Input[2]) Console.WriteLine("1");

else if (Math.Pow(Input[0], 2) + Math.Pow(Input[1], 2) == Math.Pow(Input[2], 2)) Console.WriteLine("1");
//피타고라스의 정리 
else Console.WriteLine("0");