string [] t1 = Console.ReadLine().Split(' ');
int a1 = int.Parse(t1[0]),
      a2 = int.Parse(t1[1]);
      
string [] t2 = Console.ReadLine().Split(' ');
int a3 = int.Parse(t2[0]),
      a4 = int.Parse(t2[1]);

if(a1+a4>a2+a3) Console.WriteLine("Persepolis");
else if(a1+a4<a2+a3) Console.WriteLine("Esteghlal");
else
{
      if (a2 == a4) Console.WriteLine("Penalty");
      else
      {
            if(a2<a4) Console.WriteLine("Persepolis");
            else Console.WriteLine("Esteghlal");
      }
}
      
      