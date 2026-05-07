warenkorb = []

while True:
    produkt = input("Bitte geben Sie ein Produkt ein: ")
    warenkorb.append(produkt)

    print("\nWie möchten Sie fortfahren?")
    print("w = Weiter einkaufen")
    print("b = Bestellen")
    print("a = Bestellung abbrechen")
    
    wahl = input("Ihre Wahl: ")

    if wahl == "w":
        continue
    elif wahl == "b":
        print("\nVielen Dank für Ihre Bestellung!")
        print("Ihr Warenkorb enthält:", warenkorb)
        break
    elif wahl == "a":
        print("\nDie Bestellung wurde abgebrochen.")
        break
    else:
        print("Ungültige Eingabe, der Einkauf geht weiter.")