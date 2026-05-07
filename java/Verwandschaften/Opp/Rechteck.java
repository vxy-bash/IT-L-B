public class Rechteck {
    public double laenge;
    public double breite;

    public Rechteck(double laenge, double breite) {
        this.laenge = laenge;
        this.breite = breite;
    }

    public double berechneFlaeche() {
        return laenge * breite;
    }

    public double berechneUmfang() {
        return 2 * (laenge + breite);
    }

    public static void main(String[] args) {
        Rechteck r = new Rechteck(5.0, 3.0);
        System.out.println("Fläche: " + r.berechneFlaeche());
        System.out.println("Umfang: " + r.berechneUmfang());
    }
}