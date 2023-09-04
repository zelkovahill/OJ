for(int i =0;i<3;i++)
{
    var cnt = 0;
    var A = Console.ReadLine()!.Split(' ').ToArray();

    for(int j=0;j<4;j++)
    {
        if (A[j] == "0") cnt++;
    }

   switch(cnt)
    {
        case 4: Console.WriteLine("D"); break;
        case 3: Console.WriteLine("C"); break;
        case 2: Console.WriteLine("B"); break;
        case 1: Console.WriteLine("A"); break;
        case 0: Console.WriteLine("E"); break;
    }
    


}