
warenkorb = {}

while True:
 
    produkt = input("Bitte geben Sie das Produkt ein: ")
    anzahl = input(f"Wie oft möchten Sie '{produkt}' kaufen? ")

    warenkorb.update({produkt: anzahl})

    print("\n--- Wie möchten Sie fortfahren? ---")
    print("w = Weiter einkaufen")
    print("b = Bestellen")
    print("a = Bestellung abbrechen")
    
    wahl = input("Ihre Wahl: ")

    if wahl == "w":
        print("Alles klar, das Produkt wurde hinzugefügt. Der Einkauf geht weiter.\n")
        continue
    
    elif wahl == "b":
        print("\nVielen Dank für Ihre Bestellung!")
        print("Ihre bestellten Artikel (Produkt: Anzahl):")
        print(warenkorb)
        break 
        
    elif wahl == "a":
        print("\nSchade, der Vorgang wurde abgebrochen. Der Warenkorb wird verworfen.")
        break 
        
    else:
        print("\nUngültige Eingabe. Bitte wählen Sie w, b oder a.")