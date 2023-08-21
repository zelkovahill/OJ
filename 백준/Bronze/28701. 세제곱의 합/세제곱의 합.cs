var I = int.Parse(Console.ReadLine()!);

int A = 0;
int B = 0;
int C = 0;

for (int i=1; i<=I;i++)
{
     A += i;
     B += i;
     C += i * i * i;
}

B = B * B;




Console.WriteLine(A);
Console.WriteLine(B);
Console.WriteLine(C);