def rekursiv_multiplizieren(x, y):
    """

    """
    if y == 0:
        return 0
    
    return x + rekursiv_multiplizieren(x, y - 1)

zahl1 = 6
zahl2 = 4

ergebnis = rekursiv_multiplizieren(zahl1, zahl2)

print(f"Rechnung: {zahl1} * {zahl2}")
print(f"Ergebnis: {ergebnis}")