import java.util.Scanner;

public class TestEvulation {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        System.out.println("Geben Sie ihre Punkte an.");
        int punkte = scanner.nextInt();





if (punkte<=10 && punkte>=0) {
    if (punkte == 10) {
    System.out.println("Ergebnis: Sehr Gut");
}

if (punkte == 9) {
    System.out.println("Ergebnis: Gut");
}

if (punkte == 8) {
    System.out.println("Ergebnis: Befriedigend");
}

if (punkte == 7) {
    System.out.println("Ergebnis: Ausreichend");
}

if (punkte<7) {
    System.out.println("Ergebnis: Leider nicht genügend Punkte erreicht");
}
}


else{
    System.out.println("Fehler: Ungültige Punktzahl");
}


    }
}
