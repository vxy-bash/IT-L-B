import java.util.Scanner;

public class Main {
    public static void main(String[] args) 
    {

        Scanner scanner = new Scanner(System.in);

        double x;
        double y;
        String op;
        double ergebnis;

        System.out.println("Geben Sie die erste Zahl ein:");
        x = scanner.nextDouble();

        System.out.println("Geben Sie die zweite Zahl ein:");
        y = scanner.nextDouble();

        scanner.nextLine();

        System.out.println("Geben Sie Ihre gewünschte Rechenoperation ein (+, -, *, /):");
        op = scanner.nextLine();

        if (op.equals("+")) {
            ergebnis = x + y;
            System.out.println("Ergebnis: " + ergebnis);

        } else if (op.equals("-")) {
            ergebnis = x - y;
            System.out.println("Ergebnis: " + ergebnis);

        } else if (op.equals("*")) {
            ergebnis = x * y;
            System.out.println("Ergebnis: " + ergebnis);

        } else if (op.equals("/")) {

            if (y == 0) {
                System.out.println("Durch 0 zu dividieren ist nicht möglich.");
            }

            else {
                ergebnis = x / y;
                System.out.println("Ergebnis: " + ergebnis);

            }

        } else {
            System.out.println("Ungültige Rechenoperation. Bitte geben Sie +, -, * oder / ein.");
        }

        scanner.close();
    }
}
