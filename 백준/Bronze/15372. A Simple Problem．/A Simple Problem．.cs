StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int t = int.Parse(sr.ReadLine());

for (int i = 0; i < t; i++)
{
    int n = int .Parse(sr.ReadLine());
    sw.WriteLine(Math.Pow(n,2));
}

sr.Close();
sw.Close();


    
