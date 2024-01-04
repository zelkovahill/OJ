var input = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arr=>Convert.ToInt32(arr)).ToList();


input.Sort((a,b)=>b.CompareTo(a));

Console.WriteLine(input[0]+input[1]);