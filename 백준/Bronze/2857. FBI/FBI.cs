StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());


string search = "FBI";
int cnt = 0;

   for(int i =1; i<=5;i++)
{
    string I = sr.ReadLine()!;

    if (I.Contains(search))
    { sw.Write($"{i} ");  cnt++; }
    

   
    

}

if (cnt == 0) sw.WriteLine("HE GOT AWAY!");

sr.Close();
sw.Close();