i_ = int(input("Bitte geben Sie eine Integer-Zahl ein: "))

anzahl = 0
while i_ != 0 and i_ % 5 == 0:
    i_ //= 5
    anzahl += 1

print(anzahl)