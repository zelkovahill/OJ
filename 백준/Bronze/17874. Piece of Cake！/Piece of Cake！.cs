string [] t = Console.ReadLine().Split(' ');
int n = int.Parse(t[0]),
      h = int.Parse(t[1]),
      v = int.Parse(t[2]);
      
      Console.WriteLine(4*Math.Max(h,n-h)*Math.Max(v,n-v));