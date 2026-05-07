public final class Mitarbeiter {
    private String name;
    private String abteilung;
    private double gehalt;

    public Mitarbeiter() {
        this("Unbekannt", "Keine", 0.0);
    }

    public Mitarbeiter(String name, String abteilung, double gehalt) {
        this.name = name;
        this.abteilung = abteilung;
        setGehalt(gehalt);
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getAbteilung() {
        return abteilung;
    }

    public void setAbteilung(String abteilung) {
        this.abteilung = abteilung;
    }

    public double getGehalt() {
        return gehalt;
    }

    public void setGehalt(double gehalt) {
        if (gehalt >= 0) {
            this.gehalt = gehalt;
        } else {
            throw new IllegalArgumentException("Gehalt darf nicht negativ sein.");
        }
    }
}