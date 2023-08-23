var Mon = int.Parse(Console.ReadLine()!);
var Day = int.Parse(Console.ReadLine()!);



if (Mon < 2) Console.WriteLine("Before");

else if (Mon == 2)
{
    if (Day < 18) Console.WriteLine("Before");
    else if (Day > 18) Console.WriteLine("After");
    else Console.WriteLine("Special");
}

else Console.WriteLine("After");