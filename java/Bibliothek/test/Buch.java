
public class Buch extends Medium {

    private String autor;
    private String isbn;

    public Buch() {
        super();
        this.autor = "Unbekannt";
        this.isbn = "000000";
    }

    public Buch(String titel, String autor, String isbn) {
        super(titel);
        this.autor = autor;
        this.isbn = isbn;
    }

    public String getAutor() {
        return autor;
    }

    public void setAutor(String autor) {
        this.autor = autor;
    }

    public String getIsbn() {
        return isbn;
    }

    public void setIsbn(String isbn) {
        this.isbn = isbn;
    }

    // Implementierung der abstrakten Methode (Polymorphie)
    @Override
    public String beschreibe() {
        return "Buch: " + titel + " von " + autor;
    }

    // Überschreibung der toString-Methode
    @Override
    public String toString() {
        return "Buch - Titel: " + titel + ", Autor: " + autor
                + ", ISBN: " + isbn + ", Verfügbar: " + (verfuegbar ? "Ja" : "Nein");
    }
}
