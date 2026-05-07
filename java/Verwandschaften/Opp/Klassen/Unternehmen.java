public class Unternehmen {
    private static int unternehmensCount = 0;
    private String name;
    private String branche;

    public Unternehmen(String name, String branche) {
        this.name = name;
        this.branche = branche;
        unternehmensCount++;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getBranche() {
        return branche;
    }

    public void setBranche(String branche) {
        this.branche = branche;
    }

    public static int getUnternehmensCount() {
        return unternehmensCount;
    }
}