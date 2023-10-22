int res = 0;

for(int i=0;i<10;i++)
{
    int n = int.Parse(Console.ReadLine());

    if         (n == 1)  res = (res + 1) % 4;
    else if (n == 2) res = (res + 2) % 4;
    else if (n == 3) res = (res + 3) % 4;

}




if         (res == 0) Console.WriteLine("N");
else if (res == 1) Console.WriteLine("E");
else if (res == 2) Console.WriteLine("S");
else if (res == 3) Console.WriteLine("W");