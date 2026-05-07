
public abstract class Medium {
    protected String titel;
    protected boolean verfuegbar;
    

    public Medium() {
        this.titel = "Unbekannt";
        this.verfuegbar = true;
    }
    

    public Medium(String titel) {
        this.titel = titel;
        this.verfuegbar = true;
    }
    

    public String getTitel() {
        return titel;
    }
    
    public void setTitel(String titel) {
        this.titel = titel;
    }
    
    public boolean isVerfuegbar() {
        return verfuegbar;
    }
    
    public void setVerfuegbar(boolean verfuegbar) {
        this.verfuegbar = verfuegbar;
    }
    

    public abstract String beschreibe();

    
    @Override
    public String toString() {
        return "Titel: " + titel + ", Verfügbar: " + (verfuegbar ? "Ja" : "Nein");
    }
}