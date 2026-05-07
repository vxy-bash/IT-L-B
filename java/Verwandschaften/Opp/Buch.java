public class Buch {
    public String titel;
    public String autor;
    public double preis;

    public Buch(String titel, String autor, double preis) {
        this.titel = titel;
        this.autor = autor;
        this.preis = preis;
    }

    public void erhoehePreis(double betrag) {
        preis += betrag;
    }

    public String beschreibung() {
        return titel + " von " + autor + ", Preis: " + preis;
    }

    public static void main(String[] args) {
        Buch b = new Buch("Java lernen", "Max Mustermann", 29.99);
        b.erhoehePreis(5.0);
        System.out.println(b.beschreibung());
    }
}