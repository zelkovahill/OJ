StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

var t = int.Parse(sr.ReadLine());
for(int i = 0; i < t; i++)
{
    var a = int.Parse(sr.ReadLine());
    for(int j = 0;  j < a; j++)
    {
        var b = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int sum = b[0] + b[1];
        int res = b[0] * b[1];
        sw.WriteLine($"{sum} {res}");

    }
}

sr.Close();
sw.Close();
