
import java.util.ArrayList;
import java.util.Scanner;

// Klasse für Bücher und Zeitschriften
abstract class Medium {

    private String titel;
    private boolean verfuegbar;

    public Medium(String titel) {
        this.titel = titel;
        this.verfuegbar = true;
    }

    public String getTitel() {
        return titel;
    }

    public boolean istVerfuegbar() {
        return verfuegbar;
    }

    public void setVerfuegbar(boolean verfuegbar) {
        this.verfuegbar = verfuegbar;
    }

    @Override
    public String toString() {
        return "Titel: " + titel + ", Verfügbar: " + (verfuegbar ? "Ja" : "Nein");
    }
}

// Buch mit Autor und ISBN
class Buch extends Medium {

    private String autor;
    private String isbn;

    public Buch() {
        super("Unbekannt");
        autor = "Unbekannt";
        isbn = "000000";
    }

    public Buch(String titel, String autor, String isbn) {
        super(titel);
        this.autor = autor;
        this.isbn = isbn;
    }

    public String getAutor() {
        return autor;
    }

    public String getIsbn() {
        return isbn;
    }

    @Override
    public String toString() {
        return "Titel: " + getTitel() + ", Autor: " + autor + ", ISBN: " + isbn + ", Verfügbar: " + (istVerfuegbar() ? "Ja" : "Nein");
    }
}

// Zeitschrift mit Ausgabenummer
class Zeitschrift extends Medium {

    private int ausgabeNummer;

    public Zeitschrift(String titel, int ausgabeNummer) {
        super(titel);
        this.ausgabeNummer = ausgabeNummer;
    }

    @Override
    public String toString() {
        return "Titel: " + getTitel() + ", Ausgabe: " + ausgabeNummer + ", Verfügbar: " + (istVerfuegbar() ? "Ja" : "Nein");
    }
}

// Verwaltung von medien
class Bibliothek {

    private ArrayList<Buch> buecher = new ArrayList<>();
    private ArrayList<Zeitschrift> zeitschriften = new ArrayList<>();

    public void buchHinzufuegen(Buch buch) {
        buecher.add(buch);
        System.out.println("Neues Buch wurde hinzugefügt.");
    }

    public void zeitschriftHinzufuegen(Zeitschrift z) {
        zeitschriften.add(z);
        System.out.println("Neue Zeitschrift ist jetzt verfügbar.");
    }

    public void buchAusleihen(String isbn) {
        for (Buch buch : buecher) {
            if (buch.getIsbn().equals(isbn)) {
                if (buch.istVerfuegbar()) {
                    buch.setVerfuegbar(false);
                    System.out.println("Du hast das Buch ausgeliehen.");
                } else {
                    System.out.println("Das Buch ist leider schon ausgeliehen.");
                }
                return;
            }
        }
        System.out.println("Das Buch mit der ISBN " + isbn + " wurde nicht gefunden.");
    }

    public void buchZurueckgeben(String isbn) {
        for (Buch buch : buecher) {
            if (buch.getIsbn().equals(isbn)) {
                if (!buch.istVerfuegbar()) {
                    buch.setVerfuegbar(true);
                    System.out.println("Danke, dass du das Buch zurückgegeben hast.");
                } else {
                    System.out.println("Das Buch war gar nicht ausgeliehen.");
                }
                return;
            }
        }
        System.out.println("Kein Buch mit der ISBN " + isbn + " gefunden.");
    }

    public void mediumSuchen(String suchbegriff) {
        boolean gefunden = false;
        System.out.println("Suchergebnisse:");

        for (Buch buch : buecher) {
            if (buch.getTitel().toLowerCase().contains(suchbegriff.toLowerCase())) {
                System.out.println(buch);
                gefunden = true;
            }
        }
        for (Zeitschrift z : zeitschriften) {
            if (z.getTitel().toLowerCase().contains(suchbegriff.toLowerCase())) {
                System.out.println(z);
                gefunden = true;
            }
        }

        if (!gefunden) {
            System.out.println("Leider nichts gefunden.");
        }
    }
}

// Bibliothek starten und menu
public class BibliothekApp {

    public static void main(String[] args) {
        Bibliothek bib = new Bibliothek();
        Scanner scanner = new Scanner(System.in);

        // Beispiele
        bib.buchHinzufuegen(new Buch("Harry Potter", "J.K. Rowling", "123456"));
        bib.zeitschriftHinzufuegen(new Zeitschrift("Kronen Zeitung", 42));

        while (true) {
            System.out.println("\nBitte wähle eine Option:");
            System.out.println("1 - Buch hinzufügen");
            System.out.println("2 - Buch ausleihen");
            System.out.println("3 - Buch zurückgeben");
            System.out.println("4 - Medien suchen");
            System.out.println("5 - Programm beenden");
            System.out.print("Deine Wahl: ");

            int wahl = scanner.nextInt();
            scanner.nextLine();

            if (wahl == 1) {
                System.out.print("Titel eingeben: ");
                String titel = scanner.nextLine();
                System.out.print("Autor eingeben: ");
                String autor = scanner.nextLine();
                System.out.print("ISBN eingeben: ");
                String isbn = scanner.nextLine();
                bib.buchHinzufuegen(new Buch(titel, autor, isbn));
            } else if (wahl == 2) {
                System.out.print("ISBN zum Ausleihen: ");
                String isbn = scanner.nextLine();
                bib.buchAusleihen(isbn);
            } else if (wahl == 3) {
                System.out.print("ISBN zum Zurückgeben: ");
                String isbn = scanner.nextLine();
                bib.buchZurueckgeben(isbn);
            } else if (wahl == 4) {
                System.out.print("Suchbegriff eingeben: ");
                String suchbegriff = scanner.nextLine();
                bib.mediumSuchen(suchbegriff);
            } else if (wahl == 5) {
                System.out.println("Danke und bis zum nächsten Mal!");
                break;
            } else {
                System.out.println("Bitte nochmal versuchen");
            }
        }

        scanner.close();
    }
}
