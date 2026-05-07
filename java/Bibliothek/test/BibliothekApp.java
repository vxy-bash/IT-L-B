// BibliothekApp.java - Hauptklasse mit main-Methode
import java.util.Scanner;

public class BibliothekApp {
    private static Bibliothek bibliothek = new Bibliothek();
    private static Scanner scanner = new Scanner(System.in);
    
    public static void main(String[] args) {
        System.out.println("=== Willkommen im Bibliotheksverwaltungssystem ===");
        
        boolean programmLaeuft = true;
        
        while (programmLaeuft) {
            zeigeHauptmenu();
            int auswahl = leseGanzzahl();
            
            switch (auswahl) {
                case 1:
                    buchHinzufuegen();
                    break;
                case 2:
                    zeitschriftHinzufuegen();
                    break;
                case 3:
                    buchAusleihen();
                    break;
                case 4:
                    buchZurueckgeben();
                    break;
                case 5:
                    medienSuchen();
                    break;
                case 6:
                    bibliothek.alleMedienAnzeigen();
                    break;
                case 7:
                    bibliothek.verfuegbareMedienAnzeigen();
                    break;
                case 8:
                    System.out.println("Auf Wiedersehen!");
                    programmLaeuft = false;
                    break;
                default:
                    System.out.println("Ungültige Auswahl! Bitte wählen Sie 1-8.");
            }
            
            if (programmLaeuft) {
                System.out.println("\nDrücken Sie Enter um fortzufahren...");
                scanner.nextLine();
            }
        }
        
        scanner.close();
    }
    
    private static void zeigeHauptmenu() {
        System.out.println("\n" + "=".repeat(50));
        System.out.println("HAUPTMENÜ");
        System.out.println("=".repeat(50));
        System.out.println("1. Buch hinzufügen");
        System.out.println("2. Zeitschrift hinzufügen");
        System.out.println("3. Buch ausleihen");
        System.out.println("4. Buch zurückgeben");
        System.out.println("5. Medien suchen");
        System.out.println("6. Alle Medien anzeigen");
        System.out.println("7. Verfügbare Medien anzeigen");
        System.out.println("8. Programm beenden");
        System.out.println("=".repeat(50));
        System.out.print("Ihre Auswahl (1-8): ");
    }
    
    private static void buchHinzufuegen() {
        System.out.println("\n--- Neues Buch hinzufügen ---");
        System.out.print("Titel: ");
        String titel = scanner.nextLine();
        System.out.print("Autor: ");
        String autor = scanner.nextLine();
        System.out.print("ISBN: ");
        String isbn = scanner.nextLine();
        
        Buch neuesBuch = new Buch(titel, autor, isbn);
        bibliothek.mediumHinzufuegen(neuesBuch);
    }
    
    private static void zeitschriftHinzufuegen() {
        System.out.println("\n--- Neue Zeitschrift hinzufügen ---");
        System.out.print("Titel: ");
        String titel = scanner.nextLine();
        System.out.print("Ausgabe Nummer: ");
        int ausgabeNummer = leseGanzzahl();
        scanner.nextLine(); // Buffer leeren
        
        Zeitschrift neueZeitschrift = new Zeitschrift(titel, ausgabeNummer);
        bibliothek.mediumHinzufuegen(neueZeitschrift);
    }
    
    private static void buchAusleihen() {
        System.out.println("\n--- Buch ausleihen ---");
        bibliothek.verfuegbareMedienAnzeigen();
        System.out.print("\nISBN des auszuleihenden Buchs: ");
        String isbn = scanner.nextLine();
        bibliothek.mediumAusleihen(isbn);
    }
    
    private static void buchZurueckgeben() {
        System.out.println("\n--- Buch zurückgeben ---");
        System.out.print("ISBN des zurückzugebenden Buchs: ");
        String isbn = scanner.nextLine();
        bibliothek.mediumZurueckgeben(isbn);
    }
    
    private static void medienSuchen() {
        System.out.println("\n--- Medien suchen ---");
        System.out.print("Suchbegriff (Titel): ");
        String suchbegriff = scanner.nextLine();
        bibliothek.mediumSuchen(suchbegriff);
    }
    

    
    private static int leseGanzzahl() {
        while (true) {
            try {
                return Integer.parseInt(scanner.nextLine());
            } catch (NumberFormatException e) {
                System.out.print("Bitte geben Sie eine gültige Zahl ein: ");
            }
        }
    }
}