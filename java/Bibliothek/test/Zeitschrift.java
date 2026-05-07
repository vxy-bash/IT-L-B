
public class Zeitschrift extends Medium {
    private int ausgabeNummer;
    

    public Zeitschrift() {
        super();
        this.ausgabeNummer = 1;
    }
    

    public Zeitschrift(String titel, int ausgabeNummer) {
        super(titel);
        this.ausgabeNummer = ausgabeNummer;
    }
    
    // Getter und Setter für zeitschriftspezifisches Attribut
    public int getAusgabeNummer() {
        return ausgabeNummer;
    }
    
    public void setAusgabeNummer(int ausgabeNummer) {
        this.ausgabeNummer = ausgabeNummer;
    }
    
    // Implementierung der abstrakten Methode (Polymorphie)
    @Override
    public String beschreibe() {
        return "Zeitschrift: " + titel + " (Ausgabe " + ausgabeNummer + ")";
    }
    
    // Überschreibung der toString-Methode
    @Override
    public String toString() {
        return "Zeitschrift - Titel: " + titel + ", Ausgabe: " + ausgabeNummer + 
               ", Verfügbar: " + (verfuegbar ? "Ja" : "Nein");
    }
}