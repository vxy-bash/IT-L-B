public class Adresse implements Cloneable {
    private String strasse;
    private String stadt;

    public Adresse(String strasse, String stadt) {
        this.strasse = strasse;
        this.stadt = stadt;
    }

    public String getStrasse() {
        return strasse;
    }

    public void setStrasse(String strasse) {
        this.strasse = strasse;
    }

    public String getStadt() {
        return stadt;
    }

    public void setStadt(String stadt) {
        this.stadt = stadt;
    }

    @Override
    public Adresse clone() {
        try {
            return (Adresse) super.clone();
        } catch (CloneNotSupportedException e) {
            return null;
        }
    }

    @Override
    public String toString() {
        return "Adresse[strasse=" + strasse + ", stadt=" + stadt + "]";
    }
}