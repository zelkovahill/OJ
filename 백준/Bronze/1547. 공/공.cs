using System.ComponentModel.Design;

int [] A = new int[3] {1,0,0};
int c,d;

int t = int.Parse(Console.ReadLine());



for(int i = 0; i<t; i++)
{
    string[] B = Console.ReadLine().Split(' ');
    int x = int.Parse(B[0]);
    int y = int.Parse(B[1]);

    if ((x == 1 && y == 2)|| (x == 2 && y == 1))
    {
        c = A[0];
        d = A[1];

        A[0] = d;
        A[1] = c;
    }

    else if ((x == 1 && y == 3) || (x == 3 && y == 1))
    {
        c = A[0];
        d = A[2];

        A[0] = d;
        A[2] = c;
    }

    else if ((x == 2 && y == 3) || (x == 3 && y == 2))
    {
        c = A[1];
        d = A[2];

        A[1] = d;
        A[2] = c;
    }

}
if (A[0] == 1) Console.WriteLine("1");
else if (A[1] == 1) Console.WriteLine("2");
else if (A[2] == 1) Console.WriteLine("3");
