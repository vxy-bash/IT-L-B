public class Konto implements Cloneable {
    private String kontonummer;
    private double kontostand;

    public Konto(String kontonummer, double kontostand) {
        this.kontonummer = kontonummer;
        this.kontostand = kontostand;
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

    @Override
    public Konto clone() {
        try {
            return (Konto) super.clone();
        } catch (CloneNotSupportedException e) {
            return null;
        }
    }
}