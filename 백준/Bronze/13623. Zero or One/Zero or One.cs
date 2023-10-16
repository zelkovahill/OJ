var n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

if (n[0] == n[1] && n[1] == n[2]) Console.WriteLine('*');
else if (n[0] == n[1]) Console.WriteLine('C');
else if (n[0] == n[2]) Console.WriteLine('B');
else if (n[1] == n[2]) Console.WriteLine('A');