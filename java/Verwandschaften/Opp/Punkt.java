public class Punkt {
    public double x;
    public double y;

    public Punkt(double x, double y) {
        this.x = x;
        this.y = y;
    }

    public void verschiebe(double deltaX, double deltaY) {
        x += deltaX;
        y += deltaY;
    }

    public double berechneAbstand(Punkt anderer) {
        double dx = x - anderer.x;
        double dy = y - anderer.y;
        return Math.sqrt(dx * dx + dy * dy);
    }

    public static void main(String[] args) {
        Punkt p1 = new Punkt(1.0, 2.0);
        Punkt p2 = new Punkt(4.0, 6.0);
        p1.verschiebe(2.0, -1.0);
        double abstand = p1.berechneAbstand(p2);
        System.out.println("Abstand: " + abstand);
    }
}