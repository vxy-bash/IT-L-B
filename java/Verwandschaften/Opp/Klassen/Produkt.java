public class Produkt {
    private final String produktId;
    private String name;

    public Produkt(String produktId, String name) {
        this.produktId = produktId;
        this.name = name;
    }

    public String getProduktId() {
        return produktId;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
}