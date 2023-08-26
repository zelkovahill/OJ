// StringSplitOptions.RemoveEmptyEntries 쓰임

var N = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();




Console.WriteLine(N.Length);