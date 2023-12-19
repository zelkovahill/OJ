string [] n = Console.ReadLine().Split(' ');

int a = int.Parse(n[0])-1,
    b = int.Parse(n[1])-1;
    
    int sum = Math.Abs(a/4-b/4) + Math.Abs(a%4-b%4);
    
    Console.WriteLine(sum);