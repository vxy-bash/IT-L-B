def weizenkoerner_auf_feld(n):
    """
    Berechnet rekursiv die Anzahl der Körner auf dem n-ten Feld.
    Feld 1 = 1 Korn
    Feld n = 2 * Feld(n-1)
    """
    if n == 1:
        return 1
    else:
        return 2 * weizenkoerner_auf_feld(n - 1)

if __name__ == "__main__":
    try:
        feld_nummer = int(input("Für welches Schachfeld soll die Körneranzahl berechnet werden (1-64)? "))
        
        if 1 <= feld_nummer <= 64:
            anzahl = weizenkoerner_auf_feld(feld_nummer)
            print(f"Auf Feld {feld_nummer} liegen {anzahl} Weizenkörner.")
        else:
            print("Das Schachbrett hat nur 64 Felder.")
            
    except ValueError:
        print("Bitte eine gültige Zahl eingeben.")
    except RecursionError:
        print("Rekursionstiefe überschritten (bei sehr hohen Zahlen).")