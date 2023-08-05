


import java.util.Scanner;

public class Main
{
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        float kg = scanner.nextFloat();
        float m = scanner.nextFloat();

        float BMI = kg/(m*m);

        if(BMI>25)
        {
            System.out.println("Overweight");
        }

        else if(18.5<=BMI&&BMI<=25)
        {
            System.out.println("Normal weight");
        }

        else if(18.5>BMI)
        {
            System.out.println("Underweight");
        }




    }

}
