import java.util.Scanner;

class Main
{
    public static void main(String[] args)
    {
        Scanner c = new Scanner(System.in);
        
        int A,B,C;
        
        A = c.nextInt();
            B= c.nextInt();
            C= c.nextInt();
        
        System.out.println((A+B)%C);
        System.out.println(((A%C) + (B%C))%C);
            System.out.println((A*B)%C);
                System.out.println(((A%C) * (B%C))%C);
    }
}