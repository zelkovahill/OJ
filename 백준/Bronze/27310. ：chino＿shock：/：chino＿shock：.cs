var n = Console.ReadLine();
var res =n.Length + n.Count(c => c == ':') + n.Count(c => c == '_') * 5;

Console.WriteLine(res);
