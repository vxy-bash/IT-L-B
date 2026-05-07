public class Uhr {
    public int stunden;
    public int minuten;

    public Uhr(int stunden, int minuten) {
        this.stunden = stunden;
        this.minuten = minuten;
    }

    public void setzeZeit(int stunden, int minuten) {
        this.stunden = stunden;
        this.minuten = minuten;
    }

    public void tick() {
        minuten++;
        if (minuten >= 60) {
            minuten = 0;
            stunden++;
            if (stunden >= 24) stunden = 0;
        }
    }

    public static void main(String[] args) {
        Uhr u = new Uhr(23, 58);
        u.tick();
        u.tick();
        System.out.println("Zeit: " + u.stunden + ":" + (u.minuten < 10 ? "0" : "") + u.minuten);
    }
}