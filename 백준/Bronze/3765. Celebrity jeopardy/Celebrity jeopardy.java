


import java.util.Scanner;

// Press Shift twice to open the Search Everywhere dialog and type `show whitespaces`,
// then press Enter. You can now see whitespace characters in your code.
public class Main
{
    public static void main(String[] args) {
//자바 를 10일 동안 안쓰니깐 다까먹었다.

        Scanner scanner = new Scanner(System.in);

        while (true) {
            if (scanner.hasNextLine() == false) {
                break;
            }

            String S = scanner.nextLine();
            System.out.println(S);
        }
    }
    }
