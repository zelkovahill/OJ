string [] n = Console.ReadLine().Split(' ');
int a = int.Parse(n[0]),
    b = int.Parse(n[1]);


a-=2;
b-=1;

int res = Math.Min(a,b)*2;

Console.WriteLine(3+res);