import java.util.ArrayList;
import java.util.List;

public class Kurs {
    private String kursName;
    private final List<String> teilnehmer;

    public Kurs(String kursName) {
        this.kursName = kursName;
        this.teilnehmer = new ArrayList<>();
    }

    public String getKursName() {
        return kursName;
    }

    public void setKursName(String kursName) {
        this.kursName = kursName;
    }

    public List<String> getTeilnehmer() {
        return new ArrayList<>(teilnehmer);
    }

    public void addTeilnehmer(String name) {
        teilnehmer.add(name);
    }
}