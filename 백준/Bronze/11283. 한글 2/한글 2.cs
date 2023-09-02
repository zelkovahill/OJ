StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

char input = char.Parse(sr.ReadLine()!);

sw.WriteLine((int)(input - 44031));

sr.Close();
sw.Close();