public class Adresse {
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
}