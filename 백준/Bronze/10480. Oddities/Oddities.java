


import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
       Scanner scanner = new Scanner(System.in);

       int a= scanner.nextInt();

       int[] I;
       I=new int[a];

       for(int i=0;i<a;i++)
       {

           int A = scanner.nextInt();
           I[i]=A;

       }

        for(int i=0;i<a;i++)
        {
            if(I[i]%2!=0)
            {
                System.out.printf("%d is odd",I[i]);
            }

            else
            {
                System.out.printf("%d is even",I[i]);
            }
            System.out.println();
        }




    }

}
