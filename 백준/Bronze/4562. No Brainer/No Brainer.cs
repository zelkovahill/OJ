StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int a = int.Parse(sr.ReadLine());

for (int i = 0; i < a; i++)
{
 string []t = sr.ReadLine().Split(' ');
 int b = int.Parse(t[0]);
 int c = int.Parse(t[1]);

 if (b >= c)
 {
  sw.WriteLine("MMM BRAINS");
 }
 else
 {
sw.WriteLine("NO BRAINS");
 }

}

sr.Close();
sw.Close();


    
