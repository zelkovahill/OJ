int A = int.Parse(Console.ReadLine()!);
string[] a = new string[A+1];

int count = 0;
for (int i=0;i<A;i++)
{

    
    a[i] = Console.ReadLine()!;

    if(i==A-1)
    {
        for (int j = 1; j <= A; j++)
        {
            
            Console.WriteLine(j + ". " + a[count]);
            count++;
        }
    }

}

