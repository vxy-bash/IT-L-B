// Bibliothek.java - Zentrale Logik-Klasse
import java.util.ArrayList;

public class Bibliothek {
    private ArrayList<Medium> medienListe;
    
    // Konstruktor
    public Bibliothek() {
        this.medienListe = new ArrayList<>();
        // Einige Testdaten hinzufügen
        medienListe.add(new Buch("Der Herr der Ringe", "J.R.R. Tolkien", "978-3-608-93810-4"));
        medienListe.add(new Buch("Harry Potter", "J.K. Rowling", "978-3-551-55200-0"));
        medienListe.add(new Zeitschrift("National Geographic", 202));
        medienListe.add(new Zeitschrift("Der Spiegel", 35));
    }
    
    // Medium hinzufügen
    public void mediumHinzufuegen(Medium medium) {
        medienListe.add(medium);
        System.out.println("Medium erfolgreich hinzugefügt: " + medium.beschreibe());
    }
    
    // Medium ausleihen (nach ISBN für Bücher)
    public boolean mediumAusleihen(String isbn) {
        for (Medium medium : medienListe) {
            if (medium instanceof Buch) {
                Buch buch = (Buch) medium;
                if (buch.getIsbn().equals(isbn)) {
                    if (buch.isVerfuegbar()) {
                        buch.setVerfuegbar(false);
                        System.out.println("Buch erfolgreich ausgeliehen: " + buch.beschreibe());
                        return true;
                    } else {
                        System.out.println("Buch ist bereits ausgeliehen!");
                        return false;
                    }
                }
            }
        }
        System.out.println("Buch mit ISBN " + isbn + " nicht gefunden!");
        return false;
    }
    
    // Medium zurückgeben (nach ISBN für Bücher)
    public boolean mediumZurueckgeben(String isbn) {
        for (Medium medium : medienListe) {
            if (medium instanceof Buch) {
                Buch buch = (Buch) medium;
                if (buch.getIsbn().equals(isbn)) {
                    if (!buch.isVerfuegbar()) {
                        buch.setVerfuegbar(true);
                        System.out.println("Buch erfolgreich zurückgegeben: " + buch.beschreibe());
                        return true;
                    } else {
                        System.out.println("Buch war nicht ausgeliehen!");
                        return false;
                    }
                }
            }
        }
        System.out.println("Buch mit ISBN " + isbn + " nicht gefunden!");
        return false;
    }
    
    // Medium suchen (nach Titel)
    public void mediumSuchen(String suchbegriff) {
        System.out.println("\nSuchergebnisse für '" + suchbegriff + "':");
        boolean gefunden = false;
        
        for (Medium medium : medienListe) {
            if (medium.getTitel().toLowerCase().contains(suchbegriff.toLowerCase())) {
                System.out.println("- " + medium.toString());
                gefunden = true;
            }
        }
        
        if (!gefunden) {
            System.out.println("Keine Medien gefunden.");
        }
    }
    
    // Alle Medien anzeigen
    public void alleMedienAnzeigen() {
        System.out.println("\nAlle Medien in der Bibliothek:");
        if (medienListe.isEmpty()) {
            System.out.println("Keine Medien vorhanden.");
        } else {
            for (int i = 0; i < medienListe.size(); i++) {
                System.out.println((i + 1) + ". " + medienListe.get(i).toString());
            }
        }
    }
    
    // Verfügbare Medien anzeigen
    public void verfuegbareMedienAnzeigen() {
        System.out.println("\nVerfügbare Medien:");
        boolean hatVerfuegbare = false;
        
        for (Medium medium : medienListe) {
            if (medium.isVerfuegbar()) {
                System.out.println("- " + medium.toString());
                hatVerfuegbare = true;
            }
        }
        
        if (!hatVerfuegbare) {
            System.out.println("Keine verfügbaren Medien vorhanden.");
        }
    }
}