StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

var n = int.Parse(sr.ReadLine()!);
for (int i = 1; i <= n; i++)
{

    if (i % 7 == 0 && i % 11 != 0) sw.WriteLine("Hurra!");
    else if (i % 7 != 0 && i % 11 == 0) sw.WriteLine("Super!");
    else if (i % 7 == 0 && i % 11 == 0) sw.WriteLine("Wiwat!");
    else sw.WriteLine(i);

}

sr.Close();
sw.Close();

