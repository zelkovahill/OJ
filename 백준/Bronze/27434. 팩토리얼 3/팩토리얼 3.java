import java.util.Scanner;
import java.math.BigInteger;

public class Main {

    private static final int SIMPLE_THRESHOLD = 10;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        scanner.close();

        System.out.println(factorial(n));
    }

    private static BigInteger factorial(int n) {
        return sub_fact(1, n);
    }

    private static BigInteger sub_fact(int a, int b) {
        if ((b - a) < SIMPLE_THRESHOLD) {
            BigInteger result = BigInteger.ONE;
            for (int i = a; i <= b; i++) {
                result = result.multiply(BigInteger.valueOf(i));
            }
            return result;
        } else {
            int mid = a + (b - a) / 2;
            return sub_fact(a, mid).multiply(sub_fact(mid + 1, b));
        }
    }
}