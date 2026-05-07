import random

def zahlenraten():
    zahl = random.randint(1, 100)
    versuche = 6
    print("Ich denke an eine Zahl von 1-100.")

    while versuche > 0:
        tipp = input("Dein Tipp: ")
        if not tipp.isdigit():  
            print("Bitte eine Zahl eingeben.")
            continue
        tipp = int(tipp)

        if tipp == zahl:
            print("Stimmt! Du hast gewonnen!")
            break
        elif tipp < zahl:
            versuche -= 1
            print(f"Zu niedrig. Noch {versuche} Versuche.")
        else:
            versuche -= 1
            print(f"Zu hoch. Noch {versuche} Versuche.")
    else:
        print(f"Leider verloren. Die Zahl war {zahl}.")

zahlenraten()
