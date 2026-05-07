laenge = int(input("Wie lang soll die Liste sein? "))
zahlen_liste = list(range(laenge + 1))

print("Folgende Zahlen sind Primzahlen:")

for zahl in zahlen_liste:
    if zahl < 2:
        continue
    
    for i in range(2, zahl):
        if zahl % i == 0:
            break
    else:
        print(zahl)