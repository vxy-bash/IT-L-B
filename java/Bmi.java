import java.util.Scanner;

public class Bmi {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        double x;
        double y;

        System.out.println("Geben Sie Ihr Körpergewicht in kg an: ");
        x = scanner.nextDouble();

        System.out.println("Geben Sie Ihre Körpergröße in Metern an: ");
        y = scanner.nextDouble();

        scanner.nextLine();

        double bmi = x / (y * y);


        System.out.println("Ihr bmi beträgt: " + bmi);



        scanner.close();
    }
}
