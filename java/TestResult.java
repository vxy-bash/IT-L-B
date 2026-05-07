import java.util.Scanner;

public class TestResult {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        System.out.println("Geben Sie ihre Punkte an.");
        int punkte = scanner.nextInt();


        if (punkte<=10  && punkte>0) {

            if (punkte<7) {
               System.out.println("Sie haben den Test nicht bestanden.");
            }

            else{
                System.out.println("Sie haben den Test bestanden.");
            }
          }

            else{
                System.out.println("Sie haben eine ungültige Anzahl an Punkten angegeben.");
            }
        


    }
}
