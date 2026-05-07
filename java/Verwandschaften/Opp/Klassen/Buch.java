public final class Buch {
  private String titel;
  private String autor;
  private double preis;

  public Buch(String titel, String autor, double preis) {
    this.titel = titel;
    this.autor = autor;
    setPreis(preis);
  }

  public String getTitel() {
    return titel;
  }

  public void setTitel(String titel) {
    this.titel = titel;
  }

  public String getAutor() {
    return autor;
  }

  public void setAutor(String autor) {
    this.autor = autor;
  }

  public double getPreis() {
    return preis;
  }

  public void setPreis(double preis) {
    if (preis >= 0) {
      this.preis = preis;
    }
  }

  public String getBeschreibung() {
    return "Titel: " + titel + ", Autor: " + autor;
  }
}
