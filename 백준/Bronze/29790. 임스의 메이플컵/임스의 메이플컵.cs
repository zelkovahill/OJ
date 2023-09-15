var I = Console.ReadLine()!.Split(' ').Select(int.Parse).ToList();

var N = I[0];
var U = I[1];
var L = I[2];

if (N >= 1000 && (U >= 8000 || L >= 260)) Console.WriteLine("Very Good");

else if(N >= 1000) Console.WriteLine("Good");

else Console.WriteLine("Bad");