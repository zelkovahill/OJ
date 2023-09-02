var A = int.Parse(Console.ReadLine()!);

while (true)
{

    var B = int.Parse(Console.ReadLine()!);
    if (B == 0) break;

    if (B % A == 0) Console.WriteLine($"{B} is a multiple of {A}.");
    else Console.WriteLine($"{B} is NOT a multiple of {A}.");


}