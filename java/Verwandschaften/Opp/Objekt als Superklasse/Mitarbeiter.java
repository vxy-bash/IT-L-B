public class Mitarbeiter {
    private int id;
    private String name;

    public Mitarbeiter(int id, String name) {
        this.id = id;
        this.name = name;
    }

    public int getId() {
        return id;
    }

    public String getName() {
        return name;
    }

    @Override
    public String toString() {
        return "Mitarbeiter[id=" + id + ", name=" + name + "]";
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj) return true;
        if (!(obj instanceof Mitarbeiter)) return false;
        Mitarbeiter m = (Mitarbeiter) obj;
        return id == m.id;
    }
}