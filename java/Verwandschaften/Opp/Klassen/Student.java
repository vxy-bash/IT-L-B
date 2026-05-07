public class Student {
    private String matrikelnummer;
    private double durchschnittsnote;

    public Student(String matrikelnummer, double durchschnittsnote) {
        this.matrikelnummer = matrikelnummer;
        setDurchschnittsnote(durchschnittsnote);
    }

    public String getMatrikelnummer() {
        return matrikelnummer;
    }

    public void setMatrikelnummer(String matrikelnummer) {
        this.matrikelnummer = matrikelnummer;
    }

    public double getDurchschnittsnote() {
        return durchschnittsnote;
    }

    public void setDurchschnittsnote(double durchschnittsnote) {
        if (durchschnittsnote >= 1.0 && durchschnittsnote <= 5.0) {
            this.durchschnittsnote = durchschnittsnote;
        } else {
            throw new IllegalArgumentException("Note muss zwischen 1.0 und 5.0 liegen.");
        }
    }

    public boolean istBestanden() {
        return durchschnittsnote <= 4.0;
    }
}