var N = int.Parse(Console.ReadLine()!);

var Cnt = 0;

while (N > 0)
{
    // string 을 int 형으로 
    
    var M =int.Parse (Console.ReadLine()!.Replace("D-",""));
    //Replace(이걸 , 요걸루) 바꿔줌

    if (M <= 90) Cnt++;

    N--;
}

Console.WriteLine(Cnt);