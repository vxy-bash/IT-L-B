public class Buch {
    private String titel;
    private String isbn;

    public Buch(String titel, String isbn) {
        this.titel = titel;
        this.isbn = isbn;
    }

    public String getTitel() {
        return titel;
    }

    public String getIsbn() {
        return isbn;
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj) return true;
        if (!(obj instanceof Buch)) return false;
        Buch b = (Buch) obj;
        return isbn.equals(b.isbn);
    }
}