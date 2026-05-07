using Fußball_1;

Ersatzbank ersatzbank = new Ersatzbank();   // Erstellt die Objekte
Goalie goalie = new Goalie();
Feldspieler feldspieler = new Feldspieler();
Trainer trainer = new Trainer();
Sportchef sportchef = new Sportchef();

string[] namen1 =
{
    "Leon",
    "Alexis",
    "Gabriel"
};

string[] namen = {
    "Noah",
    "Leon",
    "Matteo",
    "Elias",
    "Finn",
    "Paul",
    "Jonas",
    "Felix",
    "Alexander",
    "Michael",
    "Stefan",
    "Thomas",
    "Jakob"
};

// Random Zahl generieren
Random rnd = new Random();

// Array zu Liste Machen
List<string> namenListe = new List<string>(namen);

// Liste Mischen
for (int i = namenListe.Count - 1; i > 0; i--)
{
    int j = rnd.Next(i + 1);
    (namenListe[i], namenListe[j]) = (namenListe[j], namenListe[i]);
}

// Feldspieler generieren
for (int i = 0; i < 10; i++)
{
    feldspieler.SpielerHinzufügen(namenListe[i]);
}

//Ersatzbank zuweisen
ersatzbank.SpielerHinzufügen(namen1[0]);
ersatzbank.SpielerHinzufügen(namen1[1]);
ersatzbank.SpielerHinzufügen(namen1[2]);

// Namen zuweisen
sportchef.name = "Pascal";
trainer.name = "Herbert";
goalie.name = "Happy";

// Print-Funktion
void print()
{
    Console.WriteLine($"Sportchef:\n {sportchef.name}\n");
    Console.WriteLine($"Trainer:\n {trainer.name}\n");
    Console.WriteLine("Ersatzbank:");
    ersatzbank.SpielerAusgeben();
    Console.WriteLine("\nFeldspieler:");
    feldspieler.SpielerAusgeben();
    Console.WriteLine($"\nGoalie:\n{goalie.name}");
}

print();
Console.ReadKey();