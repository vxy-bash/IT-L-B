import java.util.ArrayList;
import java.util.List;

public class Einkauf {
    public List<String> produkte;
    public List<Double> preise;

    public Einkauf() {
        produkte = new ArrayList<>();
        preise = new ArrayList<>();
    }

    public void fuegeProduktHinzu(String produkt, double preis) {
        produkte.add(produkt);
        preise.add(preis);
    }

    public double berechneGesamtpreis() {
        double summe = 0.0;
        for (double preis : preise) summe += preis;
        return summe;
    }

    public static void main(String[] args) {
        Einkauf e = new Einkauf();
        e.fuegeProduktHinzu("Apfel", 0.79);
        e.fuegeProduktHinzu("Brot", 1.99);
        e.fuegeProduktHinzu("Milch", 1.19);
        System.out.println("Gesamtpreis: " + e.berechneGesamtpreis());
    }
}