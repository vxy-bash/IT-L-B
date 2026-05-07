public final class Auto {
  private String marke;
  private int baujahr;
  private double kilometerstand;

  public Auto() {
    this.marke = "Unbekannt";
    this.baujahr = 0;
    this.kilometerstand = 0.0;
  }


  public Auto(String marke, int baujahr, double kilometerstand) {
    this.marke = marke;
    this.baujahr = baujahr;
    setKilometerstand(kilometerstand);
  }

  public String getMarke() {
    return marke;
  }

  public void setMarke(String marke) {
    this.marke = marke;
  }

  public int getBaujahr() {
    return baujahr;
  }

  public void setBaujahr(int baujahr) {
    this.baujahr = baujahr;
  }

  public double getKilometerstand() {
    return kilometerstand;
  }

  public void setKilometerstand(double kilometerstand) {
    if (kilometerstand >= 0) {
      this.kilometerstand = kilometerstand;
    }
  }
}
