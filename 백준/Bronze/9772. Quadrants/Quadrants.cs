

while(true)
{
    string[] A = Console.ReadLine().Split();
    double x = double.Parse(A[0]);
    double y = double.Parse(A[1]);

     if (x == 0 || y == 0)
        Console.WriteLine("AXIS");

    if (x == 0 && y == 0)
    {
        break;
    }

    

    else if(x>0&&y>0)
    {
        Console.WriteLine("Q1");
    }

    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Q2");
    }

    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Q3");
    }

    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Q4");
    }


}