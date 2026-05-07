public class Kurs {
    private String kursName;
    private int teilnehmerZahl;

    public Kurs(String kursName, int teilnehmerZahl) {
        this.kursName = kursName;
        this.teilnehmerZahl = teilnehmerZahl;
    }

    public String getKursName() {
        return kursName;
    }

    public int getTeilnehmerZahl() {
        return teilnehmerZahl;
    }

    @Override
    public String toString() {
        return "Kurs[kursName=" + kursName + ", teilnehmerZahl=" +  teilnehmerZahl + "]";
    }

    public String getKursInfo() {
        return "Klasse: " + getClass().getSimpleName() + ", Kurs: " + kursName;
    }
}