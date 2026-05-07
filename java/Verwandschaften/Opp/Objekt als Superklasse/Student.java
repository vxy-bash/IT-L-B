public class Student {
    private String matrikelnummer;
    private double note;

    public Student(String matrikelnummer, double note) {
        this.matrikelnummer = matrikelnummer;
        this.note = note;
    }

    public String getMatrikelnummer() {
        return matrikelnummer;
    }

    public double getNote() {
        return note;
    }

    @Override
    public int hashCode() {
        return matrikelnummer.hashCode();
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj) return true;
        if (!(obj instanceof Student)) return false;
        Student s = (Student) obj;
        return matrikelnummer.equals(s.matrikelnummer);
    }
}