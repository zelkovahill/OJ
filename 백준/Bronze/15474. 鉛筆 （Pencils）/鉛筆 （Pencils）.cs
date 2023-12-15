String [] i = Console.ReadLine().Split(' ');
int N=int.Parse(i[0]), 
      A=int.Parse(i[1]),
      B=int.Parse(i[2]),
      C=int.Parse(i[3]),
      D=int.Parse(i[4]);

int t1=N/A+(N%A!=0?1:0),
      t2=N/C+(N%C!=0?1:0);

Console.WriteLine(t1*B>t2*D?t2*D:t1*B);
      
      