// 0.167

while (true)
{
    

    var x = double.Parse(Console.ReadLine()!);
    if (x == -1) break;
    var y = x * 0.167;

    Console.WriteLine("Objects weighing " + x.ToString("F2") + " on Earth will weigh " + y.ToString("F2") + " on the moon.");
}