public class Auto extends Fahrzeug {
  private int sitzplaetze;

  public void setSitzplaetze(int sitzplaetze){
    this.sitzplaetze = sitzplaetze;
  }

public Auto(String marke, int sitzplaetze) {
    super(marke);
    this.sitzplaetze = sitzplaetze;
  }

  public int getSitzplaetze(){
    return sitzplaetze;
  }

}
