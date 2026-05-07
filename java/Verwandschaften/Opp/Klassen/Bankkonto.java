public class Bankkonto {
    private String kontonummer;
    private double kontostand;

    public Bankkonto(String kontonummer) {
        this.kontonummer = kontonummer;
        this.kontostand = 0.0;
    }

    public String getKontonummer() {
        return kontonummer;
    }

    public void setKontonummer(String kontonummer) {
        this.kontonummer = kontonummer;
    }

    public double getKontostand() {
        return kontostand;
    }

    public void setKontostand(double kontostand) {
        this.kontostand = kontostand;
    }

    public void einzahlen(double betrag) {
        if (betrag > 0) {
            kontostand += betrag;
        }
    }
}