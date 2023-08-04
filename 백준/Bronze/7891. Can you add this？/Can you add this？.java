import java.util.Scanner;

public class Main
{
    public static void main(String args[])
    {
        Scanner scanner = new Scanner(System.in);



        int A= scanner.nextInt();
        int[] sum= new int[A];


        for(int i=0;i<A;i++)
        {
            int B = scanner.nextInt();
            int C = scanner.nextInt();
            sum[i]+=B+C;
        }

        for(int i=0;i<A;i++) 
        {
            System.out.println(sum[i]);
        }

    }
}
