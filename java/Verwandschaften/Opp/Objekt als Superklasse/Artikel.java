public class Artikel {
    private String artikelNr;
    private String beschreibung;

    public Artikel(String artikelNr, String beschreibung) {
        this.artikelNr = artikelNr;
        this.beschreibung = beschreibung;
    }

    public String getArtikelNr() {
        return artikelNr;
    }

    public String getBeschreibung() {
        return beschreibung;
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj) return true;
        if (!(obj instanceof Artikel)) return false;
        Artikel a = (Artikel) obj;
        return artikelNr.equals(a.artikelNr);
    }

    public boolean istGleicherArtikel(Artikel anderer) {
        return equals(anderer);
    }
}