


import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
       Scanner scanner = new Scanner(System.in);

       int A= scanner.nextInt();

       int[] x;
       x=new int[A];
       int[] y;
       y=new int[A];

        for(int i=0;i<A;i++)
        {
            int X= scanner.nextInt();
            int Y= scanner.nextInt();

            x[i]=X;
            y[i]=Y;
        }

        for(int i=0;i<A;i++)
        {
            for(int j=0;j<y[i];j++)
            {
                for(int k=0;k<x[i];k++)
                {
                    System.out.print("X");
                }
                System.out.println();
            }
            System.out.println();
        }



    }

}
