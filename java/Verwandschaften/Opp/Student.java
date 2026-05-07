import java.util.ArrayList;
import java.util.List;

public class Student {
    public String name;
    public List<Double> noten;

    public Student(String name) {
        this.name = name;
        this.noten = new ArrayList<>();
    }

    public void fuegeNoteHinzu(double note) {
        noten.add(note);
    }

    public double berechneDurchschnitt() {
        if (noten.isEmpty()) return 0.0;
        double summe = 0.0;
        for (double note : noten) summe += note;
        return summe / noten.size();
    }

    public static void main(String[] args) {
        Student s = new Student("Anna");
        s.fuegeNoteHinzu(1.3);
        s.fuegeNoteHinzu(2.0);
        s.fuegeNoteHinzu(1.7);
        System.out.println("Durchschnitt: " + s.berechneDurchschnitt());
    }
}