import random

spiel = ["Schere", "Stein", "Papier"]
spielstand = 0

print("Hallo und herzlich Willkommen zu Schere, Stein, Papier!")

eingabe = "" 


while eingabe != "q" and spielstand > -3:
    print("\nSchere (1), Stein (2) oder Papier (3)")
    eingabe = input("Ihre Wahl (oder q zum Beenden): ")

    if eingabe == "q":
       
        continue

    if eingabe not in ["1", "2", "3"]:
        print("Ungültige Eingabe!")
        continue

    spieler = spiel[int(eingabe) - 1]
    computer = random.choice(spiel)

    print(f"Meine Wahl: {spieler}, du hast: {computer}")

    if spieler == computer:
        print("Keiner hat gewonnen")
    elif (
        (spieler == "Schere" and computer == "Papier") or
        (spieler == "Stein" and computer == "Schere") or
        (spieler == "Papier" and computer == "Stein")
    ):
        print("Du hast gewonnen!")
        spielstand += 1
    else:
        print("Du hast verloren!")
        spielstand -= 1

    print("Spielstand:", spielstand)

    if spielstand <= -3:
        print("\nDu hast das Spiel verloren.")

print("Danke fürs Spielen")
