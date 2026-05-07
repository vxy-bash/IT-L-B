public class Konto {
    public String kontonummer;
    public double kontostand;

    public Konto(String kontonummer, double kontostand) {
        this.kontonummer = kontonummer;
        this.kontostand = kontostand;
    }

    public void einzahlen(double betrag) {
        kontostand += betrag;
    }

    public void abheben(double betrag) {
        kontostand -= betrag;
    }

    public static void main(String[] args) {
        Konto k = new Konto("123456", 1000.0);
        k.einzahlen(200.0);
        k.abheben(50.0);
        System.out.println("Kontostand: " + k.kontostand);
    }
}