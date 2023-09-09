using System.Text;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

StringBuilder b = new StringBuilder();

string [] binary ={"000","001","010","011","100","101","110","111"};

char[] I = sr.ReadLine().ToCharArray();

if (I[0] == '0')  b.Append(0);

else
{
    for (int i = 0; i < I.Length; i++)
    {
        int num = int.Parse(I[i].ToString());
        b.Append(binary[num]);
    }

    while (true)
    {
        if (b[0] == '0') b.Remove(0, 1);
        else break;
    }
}

sw.WriteLine(b);

sr.Close();
sw.Close();

   

