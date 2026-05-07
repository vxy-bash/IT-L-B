feld = [10, 20, 30, 40, 50]

laenge = len(feld)

letztes_element = feld[laenge - 1]

for i in range(laenge - 2, -1, -1):
    feld[i + 1] = feld[i]

feld[0] = letztes_element

print("Verschobene Liste:", feld)