public class Person {
  private String name;
  private int alter;

  public Person() {
    this.name = "Unbekannt";
    this.alter = 0;
  }

  public Person(String name, int alter) {
    this.name = name;
    setAlter(alter);
  }

  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public int getAlter() {
    return alter;
  }

  public void setAlter(int alter) {
    if (alter >= 0) {
      this.alter = alter;
    } else {
      System.out.println("Alter darf nicht negativ sein!");
      this.alter = 0;
    }
  }
}
