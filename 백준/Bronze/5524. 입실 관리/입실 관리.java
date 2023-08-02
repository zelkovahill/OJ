import java.util.Scanner;

public class Main {
    public static void main(String args[]) {
        Scanner scanner = new Scanner(System.in);

        int N = scanner.nextInt();
        scanner.nextLine(); // 개행문자 소비

        String[] A = new String[N];

        for (int i = 0; i < N; i++) {
            A[i] = scanner.nextLine();
        }

        for (int i = 0; i < N; i++) {
            A[i] = A[i].toLowerCase();
            System.out.println(A[i]);
        }
    }
}
