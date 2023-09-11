var Sleep = int.Parse(Console.ReadLine()!);
var Wake = int.Parse(Console.ReadLine()!);

if (Sleep <= Wake) Console.WriteLine(Wake - Sleep);
else Console.WriteLine(24 - (Sleep - Wake));

