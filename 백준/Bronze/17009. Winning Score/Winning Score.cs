var N1 = int.Parse(Console.ReadLine()!);
var N2 = int.Parse(Console.ReadLine()!);
var N3 = int.Parse(Console.ReadLine()!);
var Nsum = N1 * 3 + N2 * 2 + N3 * 1;

var M1 = int.Parse(Console.ReadLine()!);
var M2 = int.Parse(Console.ReadLine()!);
var M3 = int.Parse(Console.ReadLine()!);
var Msum = M1 * 3 + M2 * 2 + M3 * 1;

if (Nsum > Msum) Console.WriteLine("A");
if (Nsum < Msum) Console.WriteLine("B");
if (Nsum == Msum) Console.WriteLine("T");





