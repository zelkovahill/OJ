var N =Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
var M =Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

int re = 0;

if (N[0] < M[0]) re += M[0] - N[0]; 
if (N[1] < M[1]) re += M[1] - N[1]; 
if (N[2] < M[2]) re += M[2] - N[2]; 

Console.WriteLine(re);
    
    

