public class Fahrzeug {
    private String marke;

    public Fahrzeug(String marke) {
        this.marke = marke;
    }

    public String getMarke() {
        return marke;
    }

    public String getKlassenInfo() {
        return "Klasse: " + getClass().getSimpleName() + ", Marke: " + marke;
    }
}