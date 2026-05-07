import java.util.HashMap;
import java.util.Map;

public class Lager {
    public Map<String, Integer> artikel;

    public Lager() {
        artikel = new HashMap<>();
    }

    public void fuegeArtikelHinzu(String name, int menge) {
        artikel.put(name, artikel.getOrDefault(name, 0) + menge);
    }

    public void entferneArtikel(String name, int menge) {
        if (artikel.containsKey(name)) {
            int neueMenge = artikel.get(name) - menge;
            if (neueMenge > 0) {
                artikel.put(name, neueMenge);
            } else {
                artikel.remove(name);
            }
        }
    }

    public static void main(String[] args) {
        Lager l = new Lager();
        l.fuegeArtikelHinzu("Tisch", 5);
        l.fuegeArtikelHinzu("Stuhl", 10);
        l.entferneArtikel("Stuhl", 3);
        System.out.println("Tisch: " + l.artikel.get("Tisch"));
        System.out.println("Stuhl: " + l.artikel.get("Stuhl"));
    }
}