while(true)
{
    string[] A = Console.ReadLine().Split();

    string a = A[0];
    int b = int.Parse(A[1]);
    int c = int.Parse(A[2]);

    if (a == "#" && b == 0 && c == 0)
    {
        break;
    }

    if (17<b||c>=80)
    {
        Console.WriteLine(a + " Senior");
    }

    else
    {
        Console.WriteLine(a + " Junior");
    }

   

}