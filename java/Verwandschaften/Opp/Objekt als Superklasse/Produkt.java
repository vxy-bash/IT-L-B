public class Produkt {
    private String produktId;
    private double preis;

    public Produkt(String produktId, double preis) {
        this.produktId = produktId;
        this.preis = preis;
    }

    public String getProduktId() {
        return produktId;
    }

    public double getPreis() {
        return preis;
    }

    @Override
    public int hashCode() {
        return produktId.hashCode();
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj) return true;
        if (!(obj instanceof Produkt)) return false;
        Produkt p = (Produkt) obj;
        return produktId.equals(p.produktId);
    }
}