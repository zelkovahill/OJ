


import java.math.BigInteger;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        BigInteger A = new BigInteger(scanner.nextLine()); //어렵다 어려워
        BigInteger B = new BigInteger(scanner.nextLine());

        System.out.println((A.subtract(B)).divide(BigInteger.valueOf(2)).add(B));
System.out.println((A.subtract(B)).divide(BigInteger.valueOf(2)));
    }

}
