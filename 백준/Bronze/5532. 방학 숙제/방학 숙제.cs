int L = int.Parse(Console.ReadLine()!); // 방학 총 일 
int A = int.Parse(Console.ReadLine()!); // 국어 총 페이지  
int B = int.Parse(Console.ReadLine()!); // 수학 총 페이지 
int C = int.Parse(Console.ReadLine()!); // 국어 하루에 최대 풀 
int D = int.Parse(Console.ReadLine()!); // 수학 하루에 최대 풀

int AC = A / C;
int BD = B / D;

if (A % C > 0) AC++;
if (B % D > 0) BD++;

if(AC>=BD) Console.WriteLine(L - AC);
else if(AC<BD) Console.WriteLine(L - BD);






