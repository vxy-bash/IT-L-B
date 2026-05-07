public class Mitarbeiter {
    public String name;
    public double gehalt;
    public String abteilung;

    public Mitarbeiter(String name, double gehalt, String abteilung) {
        this.name = name;
        this.gehalt = gehalt;
        this.abteilung = abteilung;
    }

    public void wechselAbteilung(String neueAbteilung) {
        abteilung = neueAbteilung;
    }

    public void erhoeheGehalt(double betrag) {
        gehalt += betrag;
    }

    public static void main(String[] args) {
        Mitarbeiter m = new Mitarbeiter("Lena", 3000.0, "IT");
        m.wechselAbteilung("Personal");
        m.erhoeheGehalt(250.0);
        System.out.println(m.name + ", " + m.abteilung + ", " + m.gehalt);
    }
}